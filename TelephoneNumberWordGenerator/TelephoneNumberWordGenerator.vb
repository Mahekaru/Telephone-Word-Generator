Public Class TelephoneNumberWordGenerator
    Private Sub generateWordsButton_Click(ByVal sender As System.Object,
       ByVal e As System.EventArgs) Handles btnGenerateWords.Click

        If Not IsNumeric(txtPhoneNumber.Text) Then
            txtPhoneNumber.Text = ""
        Else
            If txtPhoneNumber.Text.Length < 7 Then
                MessageBox.Show("Phone Number Must Be 7 Digits Long")
            Else
                Dim phoneNumber As String = txtPhoneNumber.Text

                Dim letters(,) As String = {{" ", " ", " "},
                    {" ", " ", " "}, {"A", "B", "C"}, {"D", "E", "F"},
                   {"G", "H", "I"}, {"J", "K", "L"}, {"M", "N", "O"},
                   {"P", "R", "S"}, {"T", "U", "V"}, {"W", "X", "Y"}}
                Dim digits(6) As Integer

                Dim output As String = String.Empty

                For i = 0 To phoneNumber.Length - 1
                    digits(i) = phoneNumber.Substring(i, 1)
                Next

                For loop1 = 0 To 2
                    For loop2 = 0 To 2
                        For loop3 = 0 To 2
                            For loop4 = 0 To 2
                                For loop5 = 0 To 2
                                    For loop6 = 0 To 2
                                        For loop7 = 0 To 2
                                            output &= String.Format("{0, -10}",
                                               letters(digits(0), loop1) &
                                               letters(digits(1), loop2) &
                                               letters(digits(2), loop3) &
                                               letters(digits(3), loop4) &
                                               letters(digits(4), loop5) &
                                               letters(digits(5), loop6) &
                                               letters(digits(6), loop7))
                                        Next loop7
                                    Next loop6
                                Next loop5
                            Next loop4
                        Next loop3
                    Next loop2
                Next loop1

                txtOutput.Text = output
            End If
        End If
    End Sub

    Private Sub TelephoneNumberWordGenerator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
