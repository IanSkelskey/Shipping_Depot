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
        Me.SuspendLayout()
        '
        'txtTtlShip
        '
        Me.txtTtlShip.Location = New System.Drawing.Point(64, 47)
        Me.txtTtlShip.Name = "txtTtlShip"
        Me.txtTtlShip.Size = New System.Drawing.Size(100, 20)
        Me.txtTtlShip.TabIndex = 0
        '
        'txtFedEx
        '
        Me.txtFedEx.Location = New System.Drawing.Point(64, 92)
        Me.txtFedEx.Name = "txtFedEx"
        Me.txtFedEx.Size = New System.Drawing.Size(100, 20)
        Me.txtFedEx.TabIndex = 1
        '
        'txtUPS
        '
        Me.txtUPS.Location = New System.Drawing.Point(64, 135)
        Me.txtUPS.Name = "txtUPS"
        Me.txtUPS.Size = New System.Drawing.Size(100, 20)
        Me.txtUPS.TabIndex = 2
        '
        'txtUSPS
        '
        Me.txtUSPS.Location = New System.Drawing.Point(64, 182)
        Me.txtUSPS.Name = "txtUSPS"
        Me.txtUSPS.Size = New System.Drawing.Size(100, 20)
        Me.txtUSPS.TabIndex = 3
        '
        'txtFedExPerc
        '
        Me.txtFedExPerc.Location = New System.Drawing.Point(215, 92)
        Me.txtFedExPerc.Name = "txtFedExPerc"
        Me.txtFedExPerc.Size = New System.Drawing.Size(100, 20)
        Me.txtFedExPerc.TabIndex = 4
        '
        'txtUPSPerc
        '
        Me.txtUPSPerc.Location = New System.Drawing.Point(215, 135)
        Me.txtUPSPerc.Name = "txtUPSPerc"
        Me.txtUPSPerc.Size = New System.Drawing.Size(100, 20)
        Me.txtUPSPerc.TabIndex = 5
        '
        'txtUSPSPerc
        '
        Me.txtUSPSPerc.Location = New System.Drawing.Point(215, 182)
        Me.txtUSPSPerc.Name = "txtUSPSPerc"
        Me.txtUSPSPerc.Size = New System.Drawing.Size(100, 20)
        Me.txtUSPSPerc.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(361, 90)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(361, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 245)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtUSPSPerc)
        Me.Controls.Add(Me.txtUPSPerc)
        Me.Controls.Add(Me.txtFedExPerc)
        Me.Controls.Add(Me.txtUSPS)
        Me.Controls.Add(Me.txtUPS)
        Me.Controls.Add(Me.txtFedEx)
        Me.Controls.Add(Me.txtTtlShip)
        Me.Name = "Form1"
        Me.Text = "Shipping Depot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
