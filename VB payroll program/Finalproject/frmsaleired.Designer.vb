<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsaleired
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radindiana = New System.Windows.Forms.RadioButton()
        Me.radkentucky = New System.Windows.Forms.RadioButton()
        Me.radohio = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtgrosspayYTD = New System.Windows.Forms.TextBox()
        Me.txtyearlysalary = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblnetpay = New System.Windows.Forms.Label()
        Me.lblfederaltaxes = New System.Windows.Forms.Label()
        Me.lblstatetaxes = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblgrosspay = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "YTD Salary"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radindiana)
        Me.GroupBox1.Controls.Add(Me.radkentucky)
        Me.GroupBox1.Controls.Add(Me.radohio)
        Me.GroupBox1.Location = New System.Drawing.Point(87, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "States"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Yearly Salary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name"
        '
        'txtgrosspayYTD
        '
        Me.txtgrosspayYTD.Location = New System.Drawing.Point(247, 239)
        Me.txtgrosspayYTD.Name = "txtgrosspayYTD"
        Me.txtgrosspayYTD.Size = New System.Drawing.Size(100, 22)
        Me.txtgrosspayYTD.TabIndex = 13
        '
        'txtyearlysalary
        '
        Me.txtyearlysalary.Location = New System.Drawing.Point(247, 164)
        Me.txtyearlysalary.Name = "txtyearlysalary"
        Me.txtyearlysalary.Size = New System.Drawing.Size(100, 22)
        Me.txtyearlysalary.TabIndex = 12
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(247, 96)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 22)
        Me.txtlastname.TabIndex = 11
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(247, 29)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(100, 22)
        Me.txtfirstname.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(441, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Net Pay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(441, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Federal Taxes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "State Taxes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(441, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "FICA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Gross Pay"
        '
        'lblnetpay
        '
        Me.lblnetpay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnetpay.Location = New System.Drawing.Point(579, 299)
        Me.lblnetpay.Name = "lblnetpay"
        Me.lblnetpay.Size = New System.Drawing.Size(100, 33)
        Me.lblnetpay.TabIndex = 28
        '
        'lblfederaltaxes
        '
        Me.lblfederaltaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfederaltaxes.Location = New System.Drawing.Point(579, 235)
        Me.lblfederaltaxes.Name = "lblfederaltaxes"
        Me.lblfederaltaxes.Size = New System.Drawing.Size(100, 30)
        Me.lblfederaltaxes.TabIndex = 27
        '
        'lblstatetaxes
        '
        Me.lblstatetaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstatetaxes.Location = New System.Drawing.Point(579, 163)
        Me.lblstatetaxes.Name = "lblstatetaxes"
        Me.lblstatetaxes.Size = New System.Drawing.Size(100, 29)
        Me.lblstatetaxes.TabIndex = 26
        '
        'lblFICA
        '
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFICA.Location = New System.Drawing.Point(579, 95)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(100, 27)
        Me.lblFICA.TabIndex = 25
        '
        'lblgrosspay
        '
        Me.lblgrosspay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblgrosspay.Location = New System.Drawing.Point(579, 28)
        Me.lblgrosspay.Name = "lblgrosspay"
        Me.lblgrosspay.Size = New System.Drawing.Size(100, 23)
        Me.lblgrosspay.TabIndex = 24
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(357, 377)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(75, 23)
        Me.btncalculate.TabIndex = 29
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'frmsaleired
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncalculate)
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
        Me.Controls.Add(Me.txtyearlysalary)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmsaleired"
        Me.Text = "frmsaleired"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radindiana As RadioButton
    Friend WithEvents radkentucky As RadioButton
    Friend WithEvents radohio As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtgrosspayYTD As TextBox
    Friend WithEvents txtyearlysalary As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblnetpay As Label
    Friend WithEvents lblfederaltaxes As Label
    Friend WithEvents lblstatetaxes As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblgrosspay As Label
    Friend WithEvents btncalculate As Button
End Class
