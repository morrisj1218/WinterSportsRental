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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblLessDep = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.btnSnap = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDepError = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rental Form"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Equipment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Duration:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "&Pick Up Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sub Total:"
        '
        'chkInsurance
        '
        Me.chkInsurance.AutoSize = True
        Me.chkInsurance.Location = New System.Drawing.Point(14, 252)
        Me.chkInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInsurance.Name = "chkInsurance"
        Me.chkInsurance.Size = New System.Drawing.Size(158, 25)
        Me.chkInsurance.TabIndex = 7
        Me.chkInsurance.Text = "Damage &Insurance"
        Me.chkInsurance.UseVisualStyleBackColor = True
        '
        'chkWaiver
        '
        Me.chkWaiver.AutoSize = True
        Me.chkWaiver.Location = New System.Drawing.Point(14, 285)
        Me.chkWaiver.Margin = New System.Windows.Forms.Padding(4)
        Me.chkWaiver.Name = "chkWaiver"
        Me.chkWaiver.Size = New System.Drawing.Size(135, 25)
        Me.chkWaiver.TabIndex = 8
        Me.chkWaiver.Text = "&Liability Waiver"
        Me.chkWaiver.UseVisualStyleBackColor = True
        '
        'lnkWeather
        '
        Me.lnkWeather.AutoSize = True
        Me.lnkWeather.Location = New System.Drawing.Point(13, 492)
        Me.lnkWeather.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkWeather.Name = "lnkWeather"
        Me.lnkWeather.Size = New System.Drawing.Size(122, 21)
        Me.lnkWeather.TabIndex = 9
        Me.lnkWeather.TabStop = True
        Me.lnkWeather.Text = "Weather Forcast"
        '
        'clbEquipment
        '
        Me.clbEquipment.CheckOnClick = True
        Me.clbEquipment.FormattingEnabled = True
        Me.clbEquipment.Location = New System.Drawing.Point(13, 46)
        Me.clbEquipment.Margin = New System.Windows.Forms.Padding(4)
        Me.clbEquipment.Name = "clbEquipment"
        Me.clbEquipment.Size = New System.Drawing.Size(201, 196)
        Me.clbEquipment.TabIndex = 2
        '
        'cmbDuration
        '
        Me.cmbDuration.FormattingEnabled = True
        Me.cmbDuration.Location = New System.Drawing.Point(230, 106)
        Me.cmbDuration.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDuration.Name = "cmbDuration"
        Me.cmbDuration.Size = New System.Drawing.Size(154, 29)
        Me.cmbDuration.TabIndex = 4
        '
        'datePicker
        '
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker.Location = New System.Drawing.Point(230, 46)
        Me.datePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(154, 29)
        Me.datePicker.TabIndex = 6
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(8, 368)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(96, 40)
        Me.btnContinue.TabIndex = 14
        Me.btnContinue.Text = "&Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(112, 368)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(174, 40)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear &Selections"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.Info
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Location = New System.Drawing.Point(145, 60)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(141, 30)
        Me.lblSubTotal.TabIndex = 11
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(230, 248)
        Me.txtDeposit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(174, 29)
        Me.txtDeposit.TabIndex = 13
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 223)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Deposit &Amt:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblBalance)
        Me.GroupBox1.Controls.Add(Me.lblLessDep)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lblInsurance)
        Me.GroupBox1.Controls.Add(Me.btnContinue)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSubTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(616, 45)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(294, 416)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rental Snapshot"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 286)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 21)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Balance Due:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 228)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 21)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Less Deposit:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(58, 174)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Insurance:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 126)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Tax:"
        '
        'lblBalance
        '
        Me.lblBalance.BackColor = System.Drawing.SystemColors.Info
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBalance.Location = New System.Drawing.Point(145, 276)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(141, 30)
        Me.lblBalance.TabIndex = 15
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblLessDep
        '
        Me.lblLessDep.BackColor = System.Drawing.SystemColors.Info
        Me.lblLessDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLessDep.Location = New System.Drawing.Point(145, 220)
        Me.lblLessDep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLessDep.Name = "lblLessDep"
        Me.lblLessDep.Size = New System.Drawing.Size(141, 30)
        Me.lblLessDep.TabIndex = 14
        Me.lblLessDep.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblInsurance
        '
        Me.lblInsurance.BackColor = System.Drawing.SystemColors.Info
        Me.lblInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInsurance.Location = New System.Drawing.Point(145, 166)
        Me.lblInsurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(141, 30)
        Me.lblInsurance.TabIndex = 13
        Me.lblInsurance.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.Info
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(145, 116)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(141, 30)
        Me.lblTax.TabIndex = 12
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 145)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Return Date:"
        '
        'lblReturn
        '
        Me.lblReturn.BackColor = System.Drawing.SystemColors.Info
        Me.lblReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReturn.Location = New System.Drawing.Point(230, 168)
        Me.lblReturn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(154, 31)
        Me.lblReturn.TabIndex = 18
        '
        'btnSnap
        '
        Me.btnSnap.Location = New System.Drawing.Point(379, 372)
        Me.btnSnap.Name = "btnSnap"
        Me.btnSnap.Size = New System.Drawing.Size(124, 40)
        Me.btnSnap.TabIndex = 19
        Me.btnSnap.Text = "Snapshot"
        Me.btnSnap.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(816, 470)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 40)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDepError
        '
        Me.lblDepError.ForeColor = System.Drawing.Color.Red
        Me.lblDepError.Location = New System.Drawing.Point(226, 287)
        Me.lblDepError.Name = "lblDepError"
        Me.lblDepError.Size = New System.Drawing.Size(191, 65)
        Me.lblDepError.TabIndex = 21
        Me.lblDepError.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clbEquipment)
        Me.GroupBox2.Controls.Add(Me.lblDepError)
        Me.GroupBox2.Controls.Add(Me.btnSnap)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.datePicker)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.chkWaiver)
        Me.GroupBox2.Controls.Add(Me.lblReturn)
        Me.GroupBox2.Controls.Add(Me.chkInsurance)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbDuration)
        Me.GroupBox2.Controls.Add(Me.txtDeposit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(509, 418)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rental Details"
        '
        'frmRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 522)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lnkWeather)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRental"
        Me.ShowIcon = False
        Me.Text = "Winter Sports Rental"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblLessDep As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblReturn As Label
    Friend WithEvents btnSnap As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDepError As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
