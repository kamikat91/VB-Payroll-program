<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnhourlyemployee = New System.Windows.Forms.Button()
        Me.btnsaleriedemployee = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnhourlyemployee
        '
        Me.btnhourlyemployee.Location = New System.Drawing.Point(12, 12)
        Me.btnhourlyemployee.Name = "btnhourlyemployee"
        Me.btnhourlyemployee.Size = New System.Drawing.Size(219, 74)
        Me.btnhourlyemployee.TabIndex = 0
        Me.btnhourlyemployee.Text = "Hourly Employee"
        Me.btnhourlyemployee.UseVisualStyleBackColor = True
        '
        'btnsaleriedemployee
        '
        Me.btnsaleriedemployee.Location = New System.Drawing.Point(12, 104)
        Me.btnsaleriedemployee.Name = "btnsaleriedemployee"
        Me.btnsaleriedemployee.Size = New System.Drawing.Size(219, 74)
        Me.btnsaleriedemployee.TabIndex = 1
        Me.btnsaleriedemployee.Text = "Saleried Employee"
        Me.btnsaleriedemployee.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 223)
        Me.Controls.Add(Me.btnsaleriedemployee)
        Me.Controls.Add(Me.btnhourlyemployee)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnhourlyemployee As Button
    Friend WithEvents btnsaleriedemployee As Button
End Class
