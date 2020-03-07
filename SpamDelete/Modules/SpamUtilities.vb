Module SpamUtilities

    Public Function ScanEmail(Filename As String) As Integer
        Dim FileNumber As Integer
        Dim Zeile As String
        Dim idx As Integer
        Dim SpamSnippets() As String
        Dim FoundArray() As Boolean
        Dim dmy As String
        Dim pos As Integer

        'On Error GoTo ScanFileError
        idx = 0

        FileNumber = FreeFile()
        FileOpen(FileNumber, Filename, OpenMode.Input)

        Zeile = ""
        'Dim l As Integer

        While Not EOF(FileNumber)
            'Zeile = LineInput(FileNumber)
            'l = Len(Zeile)
            Zeile = Zeile & LineInput(FileNumber)
        End While
        Zeile = Zeile.Replace("=", "")
        FileClose(FileNumber)



        'walk through all Spamtexts
        For i = 0 To SpamTextArray.Length - 1
            SepariereString(SpamTextArray(i)._SearchText, SpamSnippets, ";")
            ReDim FoundArray(SpamSnippets.Length - 1)
            'Check all snippets
            For k = 0 To SpamSnippets.Length - 1
                dmy = SpamSnippets(k)
                pos = InStr(Zeile, SpamSnippets(k), CompareMethod.Text)
                If InStr(Zeile, SpamSnippets(k), CompareMethod.Text) > 0 Then
                    FoundArray(k) = True
                End If
            Next k

            ScanEmail = 1
            For k = 0 To FoundArray.Length - 1
                If FoundArray(k) = False Then
                    ScanEmail = 0
                End If
            Next k
            If ScanEmail > 0 Then
                Exit For
            End If
        Next i

        Exit Function

ScanFileError:

        MsgBox(Filename & vbCr & Err.Description, , "xxxxx")
        ScanEmail = -2
    End Function
End Module
