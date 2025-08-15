<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpPeripherals = New System.Windows.Forms.GroupBox()
        Me.chkComputer = New System.Windows.Forms.CheckBox()
        Me.chkMouse = New System.Windows.Forms.CheckBox()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.chkSpeakers = New System.Windows.Forms.CheckBox()
        Me.chkGraphicsCard = New System.Windows.Forms.CheckBox()
        Me.chkMonitor = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbHDD = New System.Windows.Forms.ComboBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.btnQuote = New System.Windows.Forms.Button()
        Me.radCrucial = New System.Windows.Forms.RadioButton()
        Me.radEaget = New System.Windows.Forms.RadioButton()
        Me.radSumsung = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaveIt = New System.Windows.Forms.SaveFileDialog()
        Me.grpPeripherals.SuspendLayout()
        Me.grp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(513, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HDD:"
        '
        'grpPeripherals
        '
        Me.grpPeripherals.Controls.Add(Me.chkComputer)
        Me.grpPeripherals.Controls.Add(Me.chkMouse)
        Me.grpPeripherals.Controls.Add(Me.chkKeyboard)
        Me.grpPeripherals.Controls.Add(Me.chkSpeakers)
        Me.grpPeripherals.Controls.Add(Me.chkGraphicsCard)
        Me.grpPeripherals.Controls.Add(Me.chkMonitor)
        Me.grpPeripherals.Location = New System.Drawing.Point(35, 165)
        Me.grpPeripherals.Name = "grpPeripherals"
        Me.grpPeripherals.Size = New System.Drawing.Size(200, 195)
        Me.grpPeripherals.TabIndex = 8
        Me.grpPeripherals.TabStop = False
        Me.grpPeripherals.Text = "Peripherals"
        '
        'chkComputer
        '
        Me.chkComputer.AutoSize = True
        Me.chkComputer.Location = New System.Drawing.Point(22, 38)
        Me.chkComputer.Name = "chkComputer"
        Me.chkComputer.Size = New System.Drawing.Size(71, 17)
        Me.chkComputer.TabIndex = 5
        Me.chkComputer.Text = "Computer"
        Me.chkComputer.UseVisualStyleBackColor = True
        '
        'chkMouse
        '
        Me.chkMouse.AutoSize = True
        Me.chkMouse.Location = New System.Drawing.Point(22, 130)
        Me.chkMouse.Name = "chkMouse"
        Me.chkMouse.Size = New System.Drawing.Size(58, 17)
        Me.chkMouse.TabIndex = 4
        Me.chkMouse.Text = "Mouse"
        Me.chkMouse.UseVisualStyleBackColor = True
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Location = New System.Drawing.Point(22, 84)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(71, 17)
        Me.chkKeyboard.TabIndex = 3
        Me.chkKeyboard.Text = "Keyboard"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'chkSpeakers
        '
        Me.chkSpeakers.AutoSize = True
        Me.chkSpeakers.Location = New System.Drawing.Point(22, 153)
        Me.chkSpeakers.Name = "chkSpeakers"
        Me.chkSpeakers.Size = New System.Drawing.Size(71, 17)
        Me.chkSpeakers.TabIndex = 2
        Me.chkSpeakers.Text = "Speakers"
        Me.chkSpeakers.UseVisualStyleBackColor = True
        '
        'chkGraphicsCard
        '
        Me.chkGraphicsCard.AutoSize = True
        Me.chkGraphicsCard.Location = New System.Drawing.Point(22, 61)
        Me.chkGraphicsCard.Name = "chkGraphicsCard"
        Me.chkGraphicsCard.Size = New System.Drawing.Size(93, 17)
        Me.chkGraphicsCard.TabIndex = 1
        Me.chkGraphicsCard.Text = "Graphics Card"
        Me.chkGraphicsCard.UseVisualStyleBackColor = True
        '
        'chkMonitor
        '
        Me.chkMonitor.AutoSize = True
        Me.chkMonitor.Location = New System.Drawing.Point(22, 107)
        Me.chkMonitor.Name = "chkMonitor"
        Me.chkMonitor.Size = New System.Drawing.Size(61, 17)
        Me.chkMonitor.TabIndex = 0
        Me.chkMonitor.Text = "Monitor"
        Me.chkMonitor.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(35, 377)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(136, 47)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(401, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 47)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(576, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 47)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmbHDD
        '
        Me.cmbHDD.FormattingEnabled = True
        Me.cmbHDD.Items.AddRange(New Object() {"EAGET 256GB", "SUMSUNG 500GB", "SEAGET 160GB"})
        Me.cmbHDD.Location = New System.Drawing.Point(553, 152)
        Me.cmbHDD.Name = "cmbHDD"
        Me.cmbHDD.Size = New System.Drawing.Size(121, 21)
        Me.cmbHDD.TabIndex = 12
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(276, 176)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(429, 186)
        Me.lstDisplay.TabIndex = 14
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(80, 63)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 16
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Label1)
        Me.grp.Controls.Add(Me.txtSurname)
        Me.grp.Controls.Add(Me.txtName)
        Me.grp.Controls.Add(Me.Label2)
        Me.grp.Location = New System.Drawing.Point(35, 46)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(200, 100)
        Me.grp.TabIndex = 17
        Me.grp.TabStop = False
        Me.grp.Text = "Personal Details"
        '
        'btnQuote
        '
        Me.btnQuote.Location = New System.Drawing.Point(228, 377)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(128, 47)
        Me.btnQuote.TabIndex = 20
        Me.btnQuote.Text = "Qoute"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'radCrucial
        '
        Me.radCrucial.AutoSize = True
        Me.radCrucial.Location = New System.Drawing.Point(6, 19)
        Me.radCrucial.Name = "radCrucial"
        Me.radCrucial.Size = New System.Drawing.Size(114, 17)
        Me.radCrucial.TabIndex = 21
        Me.radCrucial.TabStop = True
        Me.radCrucial.Text = "Crucial DDR4 8GB"
        Me.radCrucial.UseVisualStyleBackColor = True
        '
        'radEaget
        '
        Me.radEaget.AutoSize = True
        Me.radEaget.Location = New System.Drawing.Point(6, 47)
        Me.radEaget.Name = "radEaget"
        Me.radEaget.Size = New System.Drawing.Size(118, 17)
        Me.radEaget.TabIndex = 22
        Me.radEaget.TabStop = True
        Me.radEaget.Text = "EAGET DDR4 8GB"
        Me.radEaget.UseVisualStyleBackColor = True
        '
        'radSumsung
        '
        Me.radSumsung.AutoSize = True
        Me.radSumsung.Location = New System.Drawing.Point(6, 70)
        Me.radSumsung.Name = "radSumsung"
        Me.radSumsung.Size = New System.Drawing.Size(137, 17)
        Me.radSumsung.TabIndex = 23
        Me.radSumsung.TabStop = True
        Me.radSumsung.Text = "SUMSUNG DDR4 4GB"
        Me.radSumsung.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.myproject.My.Resources.Resources.ChatGPT_Image_Aug_11__2025__11_54_33_AM
        Me.PictureBox1.Location = New System.Drawing.Point(276, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCrucial)
        Me.GroupBox1.Controls.Add(Me.radEaget)
        Me.GroupBox1.Controls.Add(Me.radSumsung)
        Me.GroupBox1.Location = New System.Drawing.Point(505, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ram"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuote)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.cmbHDD)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpPeripherals)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form1"
        Me.Text = "Nqatyelwa's Computer"
        Me.grpPeripherals.ResumeLayout(False)
        Me.grpPeripherals.PerformLayout()
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grpPeripherals As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbHDD As ComboBox
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents chkMouse As CheckBox
    Friend WithEvents chkKeyboard As CheckBox
    Friend WithEvents chkSpeakers As CheckBox
    Friend WithEvents chkGraphicsCard As CheckBox
    Friend WithEvents chkMonitor As CheckBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents grp As GroupBox
    Friend WithEvents btnQuote As Button
    Friend WithEvents radCrucial As RadioButton
    Friend WithEvents radEaget As RadioButton
    Friend WithEvents radSumsung As RadioButton
    Friend WithEvents chkComputer As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SaveIt As SaveFileDialog
End Class
