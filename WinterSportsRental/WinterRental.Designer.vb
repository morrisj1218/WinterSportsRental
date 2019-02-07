<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkInsurance = New System.Windows.Forms.CheckBox()
        Me.chkWaiver = New System.Windows.Forms.CheckBox()
        Me.lnkWeather = New System.Windows.Forms.LinkLabel()
        Me.clbEquipment = New System.Windows.Forms.CheckedListBox()
        Me.cmbDuration = New System.Windows.Forms.ComboBox()
        Me.datPicker = New System.Windows.Forms.DateTimePicker()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Winter Sports Rental"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(579, 479)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Balance Due:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Equipment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Duration:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(579, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(579, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sub Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(579, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tax:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(579, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Insurance:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(579, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Deposit:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(579, 514)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Due Back:"
        '
        'chkInsurance
        '
        Me.chkInsurance.AutoSize = True
        Me.chkInsurance.Location = New System.Drawing.Point(349, 191)
        Me.chkInsurance.Name = "chkInsurance"
        Me.chkInsurance.Size = New System.Drawing.Size(135, 21)
        Me.chkInsurance.TabIndex = 10
        Me.chkInsurance.Text = "Damage Insurance"
        Me.chkInsurance.UseVisualStyleBackColor = True
        '
        'chkWaiver
        '
        Me.chkWaiver.AutoSize = True
        Me.chkWaiver.Location = New System.Drawing.Point(349, 218)
        Me.chkWaiver.Name = "chkWaiver"
        Me.chkWaiver.Size = New System.Drawing.Size(113, 21)
        Me.chkWaiver.TabIndex = 11
        Me.chkWaiver.Text = "Liability Waiver"
        Me.chkWaiver.UseVisualStyleBackColor = True
        '
        'lnkWeather
        '
        Me.lnkWeather.AutoSize = True
        Me.lnkWeather.Location = New System.Drawing.Point(97, 409)
        Me.lnkWeather.Name = "lnkWeather"
        Me.lnkWeather.Size = New System.Drawing.Size(102, 17)
        Me.lnkWeather.TabIndex = 12
        Me.lnkWeather.TabStop = True
        Me.lnkWeather.Text = "Weather Forcast"
        '
        'clbEquipment
        '
        Me.clbEquipment.FormattingEnabled = True
        Me.clbEquipment.Location = New System.Drawing.Point(82, 74)
        Me.clbEquipment.Name = "clbEquipment"
        Me.clbEquipment.Size = New System.Drawing.Size(228, 164)
        Me.clbEquipment.TabIndex = 13
        '
        'cmbDuration
        '
        Me.cmbDuration.FormattingEnabled = True
        Me.cmbDuration.Location = New System.Drawing.Point(349, 74)
        Me.cmbDuration.Name = "cmbDuration"
        Me.cmbDuration.Size = New System.Drawing.Size(121, 25)
        Me.cmbDuration.TabIndex = 14
        '
        'datPicker
        '
        Me.datPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datPicker.Location = New System.Drawing.Point(582, 74)
        Me.datPicker.Name = "datPicker"
        Me.datPicker.Size = New System.Drawing.Size(126, 25)
        Me.datPicker.TabIndex = 15
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(277, 488)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 32)
        Me.btnContinue.TabIndex = 16
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(358, 488)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 32)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear Selections"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.datPicker)
        Me.Controls.Add(Me.cmbDuration)
        Me.Controls.Add(Me.clbEquipment)
        Me.Controls.Add(Me.lnkWeather)
        Me.Controls.Add(Me.chkWaiver)
        Me.Controls.Add(Me.chkInsurance)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRental"
        Me.ShowIcon = False
        Me.Text = "Winter Sports Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents chkInsurance As CheckBox
    Friend WithEvents chkWaiver As CheckBox
    Friend WithEvents lnkWeather As LinkLabel
    Friend WithEvents clbEquipment As CheckedListBox
    Friend WithEvents cmbDuration As ComboBox
    Friend WithEvents datPicker As DateTimePicker
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnClear As Button
End Class
