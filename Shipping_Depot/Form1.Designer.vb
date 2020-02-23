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
        Me.txtTtlShip = New System.Windows.Forms.TextBox()
        Me.txtFedEx = New System.Windows.Forms.TextBox()
        Me.txtUPS = New System.Windows.Forms.TextBox()
        Me.txtUSPS = New System.Windows.Forms.TextBox()
        Me.txtFedExPerc = New System.Windows.Forms.TextBox()
        Me.txtUPSPerc = New System.Windows.Forms.TextBox()
        Me.txtUSPSPerc = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTtlShip
        '
        Me.txtTtlShip.Location = New System.Drawing.Point(20, 35)
        Me.txtTtlShip.Name = "txtTtlShip"
        Me.txtTtlShip.Size = New System.Drawing.Size(75, 20)
        Me.txtTtlShip.TabIndex = 0
        '
        'txtFedEx
        '
        Me.txtFedEx.Location = New System.Drawing.Point(20, 74)
        Me.txtFedEx.Name = "txtFedEx"
        Me.txtFedEx.Size = New System.Drawing.Size(75, 20)
        Me.txtFedEx.TabIndex = 1
        '
        'txtUPS
        '
        Me.txtUPS.Location = New System.Drawing.Point(20, 113)
        Me.txtUPS.Name = "txtUPS"
        Me.txtUPS.Size = New System.Drawing.Size(75, 20)
        Me.txtUPS.TabIndex = 2
        '
        'txtUSPS
        '
        Me.txtUSPS.Location = New System.Drawing.Point(20, 152)
        Me.txtUSPS.Name = "txtUSPS"
        Me.txtUSPS.Size = New System.Drawing.Size(75, 20)
        Me.txtUSPS.TabIndex = 3
        '
        'txtFedExPerc
        '
        Me.txtFedExPerc.Location = New System.Drawing.Point(117, 74)
        Me.txtFedExPerc.Name = "txtFedExPerc"
        Me.txtFedExPerc.Size = New System.Drawing.Size(75, 20)
        Me.txtFedExPerc.TabIndex = 4
        '
        'txtUPSPerc
        '
        Me.txtUPSPerc.Location = New System.Drawing.Point(117, 113)
        Me.txtUPSPerc.Name = "txtUPSPerc"
        Me.txtUPSPerc.Size = New System.Drawing.Size(75, 20)
        Me.txtUPSPerc.TabIndex = 5
        '
        'txtUSPSPerc
        '
        Me.txtUSPSPerc.Location = New System.Drawing.Point(117, 152)
        Me.txtUSPSPerc.Name = "txtUSPSPerc"
        Me.txtUSPSPerc.Size = New System.Drawing.Size(75, 20)
        Me.txtUSPSPerc.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(240, 48)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(240, 84)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFedEx)
        Me.GroupBox1.Controls.Add(Me.txtTtlShip)
        Me.GroupBox1.Controls.Add(Me.txtUPS)
        Me.GroupBox1.Controls.Add(Me.txtUSPSPerc)
        Me.GroupBox1.Controls.Add(Me.txtUSPS)
        Me.GroupBox1.Controls.Add(Me.txtUPSPerc)
        Me.GroupBox1.Controls.Add(Me.txtFedExPerc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 191)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total Shipped:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "FedEx:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "UPS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "USPS:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 215)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "Form1"
        Me.Text = "Shipping Depot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTtlShip As TextBox
    Friend WithEvents txtFedEx As TextBox
    Friend WithEvents txtUPS As TextBox
    Friend WithEvents txtUSPS As TextBox
    Friend WithEvents txtFedExPerc As TextBox
    Friend WithEvents txtUPSPerc As TextBox
    Friend WithEvents txtUSPSPerc As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
