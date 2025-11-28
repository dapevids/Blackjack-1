Imports System.Runtime.InteropServices
Public Class Form1
    Dim deck(51) As String
    Dim ShuffledDeck(51) As String
    Dim ShuffledDeckValues(51) As Integer
    Dim Masterdeck() As String = {"2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "10h", "Jh", "Qh", "Kh", "Ah", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "10d", "Jd", "Qd", "Kd", "Ad", "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "10c", "Jc", "Qc", "Kc", "Ac", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "10s", "Js", "Qs", "Ks", "As"}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim de As String = 1
        create_a_deck()

        TextBox1.Text = String.Join(", ", shuffle_deck())
        TextBox2.Text = String.Join(", ", ShuffledDeckValues)
    End Sub
    Function create_a_deck() As String()
        deck = New String(51) {}
        Dim i As Integer = 0
        For i = 0 To 51
            deck(i) = Masterdeck(i)
        Next i
        Return deck
    End Function

    Function shuffle_deck() As String()
        ShuffledDeck = New String(51) {}
        ShuffledDeckValues = New Integer(51) {}
        Dim i As Integer = 0
        Dim R As New Random
        Dim card As String = "X"
        Dim index As Integer = 0

        For i = 0 To 51
            index = R.Next(0, deck.Length)
            card = deck(index)
            If card = "X" Then
                Do
                    index += 1
                    If index > 51 Then
                        index = 0
                    End If
                Loop While deck(index) = "X"

                card = deck(index)
            End If

            ShuffledDeck(i) = card
            ShuffledDeckValues(i) = get_card_value(card)

            deck(index) = "X"
        Next i

        Return ShuffledDeck
    End Function

    Function get_card_value(card_name As String) As Integer
        If card_name = "2c" Or card_name = "2h" Or card_name = "2s" Or card_name = "2d" Then
            Return 2
        ElseIf card_name = "3c" Or card_name = "3h" Or card_name = "3s" Or card_name = "3d" Then
            Return 3
        ElseIf card_name = "4c" Or card_name = "4h" Or card_name = "4s" Or card_name = "4d" Then
            Return 4
        ElseIf card_name = "5c" Or card_name = "5h" Or card_name = "5s" Or card_name = "5d" Then
            Return 5
        ElseIf card_name = "6c" Or card_name = "6h" Or card_name = "6s" Or card_name = "6d" Then
            Return 6
        ElseIf card_name = "7c" Or card_name = "7h" Or card_name = "7s" Or card_name = "7d" Then
            Return 7
        ElseIf card_name = "8c" Or card_name = "8" Or card_name = "8s" Or card_name = "8d" Then
            Return 8
        ElseIf card_name = "9c" Or card_name = "9h" Or card_name = "9s" Or card_name = "9d" Then
            Return 9
        ElseIf card_name = "10c" Or card_name = "10h" Or card_name = "10s" Or card_name = "10d" Then
            Return 10
        ElseIf card_name = "Jc" Or card_name = "Jh" Or card_name = "Js" Or card_name = "Jd" Then
            Return 10
        ElseIf card_name = "Qc" Or card_name = "Qh" Or card_name = "Qs" Or card_name = "Qd" Then
            Return 10
        ElseIf card_name = "Kc" Or card_name = "Kh" Or card_name = "Ks" Or card_name = "Kd" Then
            Return 10
        ElseIf card_name = "Ac" Or card_name = "Ah" Or card_name = "As" Or card_name = "Ad" Then
            Return 11
        End If
        Return 0
    End Function
End Class


