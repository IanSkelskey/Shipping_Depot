Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intNumberShipped(4, 3) As Integer
        Dim intTotalShipped, intFedExTotal, intUPSTotal, intUSPSTotal As Integer
        Dim dblFedExPerc, dblUPSPerc, dblUSPSPerc As Double

        intNumberShipped = {{225, 216, 150},
                               {199, 225, 215},
                               {230, 200, 225},
                               {150, 175, 200}}
        For intRow As Integer = 0 To 3
            intFedExTotal += intNumberShipped(intRow, 0)
            intUPSTotal += intNumberShipped(intRow, 1)
            intUSPSTotal += intNumberShipped(intRow, 2)
        Next

        intTotalShipped = intFedExTotal + intUPSTotal + intUSPSTotal

        dblFedExPerc = intFedExTotal / intTotalShipped
        dblUPSPerc = intUPSTotal / intTotalShipped
        dblUSPSPerc = intUSPSTotal / intTotalShipped

        txtTtlShip.Text = intTotalShipped.ToString
        txtFedEx.Text = intFedExTotal.ToString
        txtUPS.Text = intUPSTotal.ToString
        txtUSPS.Text = intUSPSTotal.ToString

        txtFedExPerc.Text = dblFedExPerc.ToString("P0")
        txtUPSPerc.Text = dblUPSPerc.ToString("P0")
        txtUSPSPerc.Text = dblUSPSPerc.ToString("P0")

    End Sub
End Class
