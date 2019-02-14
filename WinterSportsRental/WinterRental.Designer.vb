<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRental
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkInsurance = New System.Windows.Forms.CheckBox()
        Me.chkWaiver = New System.Windows.Forms.CheckBox()
        Me.lnkWeather = New System.Windows.Forms.LinkLabel()
        Me.clbEquipment = New System.Windows.Forms.CheckedListBox()
        Me.cmbDuration = New System.Windows.Forms.ComboBox()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Winter Sports Rental"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Equipment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Duration:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(529, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "&Pick Up Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(451, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sub Total:"
        '
        'chkInsurance
        '
        Me.chkInsurance.AutoSize = True
        Me.chkInsurance.Location = New System.Drawing.Point(364, 146)
        Me.chkInsurance.Name = "chkInsurance"
        Me.chkInsurance.Size = New System.Drawing.Size(135, 21)
        Me.chkInsurance.TabIndex = 7
        Me.chkInsurance.Text = "Damage &Insurance"
        Me.chkInsurance.UseVisualStyleBackColor = True
        '
        'chkWaiver
        '
        Me.chkWaiver.AutoSize = True
        Me.chkWaiver.Location = New System.Drawing.Point(364, 173)
        Me.chkWaiver.Name = "chkWaiver"
        Me.chkWaiver.Size = New System.Drawing.Size(113, 21)
        Me.chkWaiver.TabIndex = 8
        Me.chkWaiver.Text = "&Liability Waiver"
        Me.chkWaiver.UseVisualStyleBackColor = True
        '
        'lnkWeather
        '
        Me.lnkWeather.AutoSize = True
        Me.lnkWeather.Location = New System.Drawing.Point(94, 354)
        Me.lnkWeather.Name = "lnkWeather"
        Me.lnkWeather.Size = New System.Drawing.Size(102, 17)
        Me.lnkWeather.TabIndex = 9
        Me.lnkWeather.TabStop = True
        Me.lnkWeather.Text = "Weather Forcast"
        '
        'clbEquipment
        '
        Me.clbEquipment.CheckOnClick = True
        Me.clbEquipment.FormattingEnabled = True
        Me.clbEquipment.Location = New System.Drawing.Point(97, 74)
        Me.clbEquipment.Name = "clbEquipment"
        Me.clbEquipment.Size = New System.Drawing.Size(228, 164)
        Me.clbEquipment.TabIndex = 2
        '
        'cmbDuration
        '
        Me.cmbDuration.FormattingEnabled = True
        Me.cmbDuration.Location = New System.Drawing.Point(364, 74)
        Me.cmbDuration.Name = "cmbDuration"
        Me.cmbDuration.Size = New System.Drawing.Size(121, 25)
        Me.cmbDuration.TabIndex = 4
        '
        'datePicker
        '
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker.Location = New System.Drawing.Point(532, 74)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(126, 25)
        Me.datePicker.TabIndex = 6
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(442, 346)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 32)
        Me.btnContinue.TabIndex = 14
        Me.btnContinue.Text = "&Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(523, 346)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 32)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear &Selections"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Yellow
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Location = New System.Drawing.Point(522, 263)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(136, 25)
        Me.lblSubTotal.TabIndex = 11
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(522, 291)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(136, 25)
        Me.txtDeposit.TabIndex = 13
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(433, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Deposit &Amt:"
        '
        'frmRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 460)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.datePicker)
        Me.Controls.Add(Me.cmbDuration)
        Me.Controls.Add(Me.clbEquipment)
        Me.Controls.Add(Me.lnkWeather)
        Me.Controls.Add(Me.chkWaiver)
        Me.Controls.Add(Me.chkInsurance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkInsurance As CheckBox
    Friend WithEvents chkWaiver As CheckBox
    Friend WithEvents lnkWeather As LinkLabel
    Friend WithEvents clbEquipment As CheckedListBox
    Friend WithEvents cmbDuration As ComboBox
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents Label2 As Label
End Class
