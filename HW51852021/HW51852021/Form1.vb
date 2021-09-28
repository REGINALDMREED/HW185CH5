Public Class frmWeightConversion
    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        'to clear textbox, label text and reset radio
        txtWeight.Clear()
        lblDisplayWeight.Text = ""
        radPTK.Checked = True
        radKTP.Checked = False
        'Calculation for conversion weight and display its
        'Declaration section
        Dim decWeight As Decimal
        Dim decConvertWeight As Decimal
        'Did user enter a numeric value?
        If IsNimeric(txtWeight) Then
            decWeight = Convert.ToDecimal(txtWeight.Text)
            'To enter Weight is greater than zero
            If decWeight > 0 Then
                'Determine converted weight
                If radptk.Checked Then
                    decConvertWeight = decWeight / 2.2046
                    'display converted weight in kilograms
                    lblDisplayWeight.Text = "The Weight of the patient is" & decConvertWeight.ToString("N3") & "
             kilograms."
                    Elself radPTK.Checked Then
                    decConvertWeight = decWeight * 2.2046
                    'display converted weight in pounds
                    lblDisplayWeight.Text = "The Weight of the patient is" & decConvertWeight.ToString("N3") & "
                 pounds."
                End If
            Else
                'Display error message if user entered a negative value
                MsgBox("You Entered" & decWeight.ToString() & ". Enter a Positive Number",, "Input Error")
                txtWeight.Text = ""
                txtWeight.Focus()
            End If
        Else
            'Display error message if user enterd invalid numbers
            MsgBox9("You Entered" & decWeight.ToString() & ".Enter a Positive Number",, "Input Error")
            txtWeight.Text = ""
            textWeight.Focus()
        End If
        Else
        'Display error message if user entered invalid numbers
        MsgBox("Enter the Valid Number(s)",, "Input Error")
        txtWeight.Text = ""
        txtWeight.Focus()
        End If
    End Sub
End Class


Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    Dim txtWeight As Object = Nothing
    'to clear textbox, label text, and reset radio
    txtWeight.Clear()

    lblDisplayWeight.Text = ""

    radPTK.Checked = True

    radKTP.Checked = False
End Sub
