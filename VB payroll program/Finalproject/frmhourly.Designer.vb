<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhourly
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radohio = New System.Windows.Forms.RadioButton()
        Me.radkentucky = New System.Windows.Forms.RadioButton()
        Me.radindiana = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txthourlypay = New System.Windows.Forms.TextBox()
        Me.txtgrosspayYTD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblgrosspay = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblstatetaxes = New System.Windows.Forms.Label()
        Me.lblfederaltaxes = New System.Windows.Forms.Label()
        Me.lblnetpay = New System.Windows.Forms.Label()
        Me.txthoursworked = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hourly Pay"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radindiana)
        Me.GroupBox1.Controls.Add(Me.radkentucky)
        Me.GroupBox1.Controls.Add(Me.radohio)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "States"
        '
        'radohio
        '
        Me.radohio.AutoSize = True
        Me.radohio.Location = New System.Drawing.Point(7, 22)
        Me.radohio.Name = "radohio"
        Me.radohio.Size = New System.Drawing.Size(56, 20)
        Me.radohio.TabIndex = 0
        Me.radohio.TabStop = True
        Me.radohio.Text = "Ohio"
        Me.radohio.UseVisualStyleBackColor = True
        '
        'radkentucky
        '
        Me.radkentucky.AutoSize = True
        Me.radkentucky.Location = New System.Drawing.Point(7, 49)
        Me.radkentucky.Name = "radkentucky"
        Me.radkentucky.Size = New System.Drawing.Size(82, 20)
        Me.radkentucky.TabIndex = 1
        Me.radkentucky.TabStop = True
        Me.radkentucky.Text = "Kentucky"
        Me.radkentucky.UseVisualStyleBackColor = True
        '
        'radindiana
        '
        Me.radindiana.AutoSize = True
        Me.radindiana.Location = New System.Drawing.Point(7, 76)
        Me.radindiana.Name = "radindiana"
        Me.radindiana.Size = New System.Drawing.Size(72, 20)
        Me.radindiana.TabIndex = 2
        Me.radindiana.TabStop = True
        Me.radindiana.Text = "Indiana"
        Me.radindiana.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "YTD Salary"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(225, 30)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(100, 22)
        Me.txtfirstname.TabIndex = 5
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(225, 97)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 22)
        Me.txtlastname.TabIndex = 6
        '
        'txthourlypay
        '
        Me.txthourlypay.Location = New System.Drawing.Point(225, 165)
        Me.txthourlypay.Name = "txthourlypay"
        Me.txthourlypay.Size = New System.Drawing.Size(100, 22)
        Me.txthourlypay.TabIndex = 7
        '
        'txtgrosspayYTD
        '
        Me.txtgrosspayYTD.Location = New System.Drawing.Point(229, 273)
        Me.txtgrosspayYTD.Name = "txtgrosspayYTD"
        Me.txtgrosspayYTD.Size = New System.Drawing.Size(100, 22)
        Me.txtgrosspayYTD.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Gross Pay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(419, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "FICA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "State Taxes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Federal Taxes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(419, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Net Pay"
        '
        'lblgrosspay
        '
        Me.lblgrosspay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblgrosspay.Location = New System.Drawing.Point(575, 36)
        Me.lblgrosspay.Name = "lblgrosspay"
        Me.lblgrosspay.Size = New System.Drawing.Size(100, 23)
        Me.lblgrosspay.TabIndex = 14
        '
        'lblFICA
        '
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFICA.Location = New System.Drawing.Point(575, 103)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(100, 27)
        Me.lblFICA.TabIndex = 15
        '
        'lblstatetaxes
        '
        Me.lblstatetaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstatetaxes.Location = New System.Drawing.Point(575, 171)
        Me.lblstatetaxes.Name = "lblstatetaxes"
        Me.lblstatetaxes.Size = New System.Drawing.Size(100, 29)
        Me.lblstatetaxes.TabIndex = 16
        '
        'lblfederaltaxes
        '
        Me.lblfederaltaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfederaltaxes.Location = New System.Drawing.Point(575, 243)
        Me.lblfederaltaxes.Name = "lblfederaltaxes"
        Me.lblfederaltaxes.Size = New System.Drawing.Size(100, 30)
        Me.lblfederaltaxes.TabIndex = 17
        '
        'lblnetpay
        '
        Me.lblnetpay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnetpay.Location = New System.Drawing.Point(575, 307)
        Me.lblnetpay.Name = "lblnetpay"
        Me.lblnetpay.Size = New System.Drawing.Size(100, 33)
        Me.lblnetpay.TabIndex = 18
        '
        'txthoursworked
        '
        Me.txthoursworked.Location = New System.Drawing.Point(229, 219)
        Me.txthoursworked.Name = "txthoursworked"
        Me.txthoursworked.Size = New System.Drawing.Size(100, 22)
        Me.txthoursworked.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Hours Worked"
        '
        'frmhourly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txthoursworked)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblnetpay)
        Me.Controls.Add(Me.lblfederaltaxes)
        Me.Controls.Add(Me.lblstatetaxes)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblgrosspay)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtgrosspayYTD)
        Me.Controls.Add(Me.txthourlypay)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmhourly"
        Me.Text = "frmhourly"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radohio As RadioButton
    Friend WithEvents radindiana As RadioButton
    Friend WithEvents radkentucky As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txthourlypay As TextBox
    Friend WithEvents txtgrosspayYTD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblgrosspay As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblstatetaxes As Label
    Friend WithEvents lblfederaltaxes As Label
    Friend WithEvents lblnetpay As Label
    Friend WithEvents txthoursworked As TextBox
    Friend WithEvents Label10 As Label
End Class
