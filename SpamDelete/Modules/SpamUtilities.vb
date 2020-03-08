Module SpamUtilities

    Public Function ScanEmail(Filename As String) As Integer
        Dim FileNumber As Integer
        Dim Zeile As String
        Dim idx As Integer
        Dim SpamSnippets() As String
        Dim FoundArray() As Boolean
        Dim dmy As String
        Dim pos As Integer
        Dim TooBig As Boolean

        On Error GoTo ScanFileError
        idx = 0

        FileNumber = FreeFile()
        FileOpen(FileNumber, Filename, OpenMode.Input)

        Zeile = ""


        While Not EOF(FileNumber)
            idx = idx + 1
            NumberLinesScanned = idx
            Application.DoEvents()
            If idx > 9999 Then
                TooBig = True       ' Big file is usually not SPAM
                ScanEmail = 0
                Exit Function
            End If
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
                'NumberLinesScanned = i
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

    Public Function ConvertOriginalToSearchText(OriginalText As String) As String
        Dim Input As String
        Dim a As Integer
        Dim NewString As String

        NewString = ""
        Input = OriginalText
        For Each c As Char In Input.ToCharArray 'Input ist ein String

            If Not Char.IsLetter(c) _
                Or c = "Ä" _
                Or c = "ä" _
                Or c = "Ö" _
                Or c = "ö" _
                Or c = "Ü" _
                Or c = "ü" _
                Or c = "ß" _
            Then
                NewString = NewString & ";"
            Else
                NewString = NewString & c
            End If

        Next

        ConvertOriginalToSearchText = NewString

    End Function


    Public Sub ReplaceSubject(FileName)
        Dim FileNumber As Integer
        Dim Zeile As String
        Dim idx As Long
        Dim EmailContentArray()
        Dim Pos As Integer

        ReDim EmailContentArray(0 To 0)

        On Error GoTo ReadHistoryFileErr

        FileNumber = FreeFile()
        FileOpen(FileNumber, FileName, OpenMode.Input)

        While Not EOF(FileNumber)
            Zeile = LineInput(FileNumber)
            Pos = InStr(Zeile, "Subject:", CompareMethod.Text)
            If Pos = 1 Then
                EmailContentArray(idx) = "Subject: ***********MurxSpam***************"
            Else
                EmailContentArray(idx) = Zeile
            End If
            idx = idx + 1
            ReDim Preserve EmailContentArray(0 To UBound(EmailContentArray) + 1)
        End While

        ReDim Preserve EmailContentArray(0 To UBound(EmailContentArray) - 1)

        FileClose(FileNumber)

        FileNumber = FreeFile()
        FileOpen(FileNumber, FileName, OpenMode.Output)

        For idx = 0 To UBound(EmailContentArray)
            Zeile = EmailContentArray(idx)
            PrintLine(FileNumber, Zeile)
        Next idx

        FileClose(FileNumber)


        Exit Sub
ReadHistoryFileErr:
        MsgBox(FileName & vbCr & Err.Description, , "xxxxx")
    End Sub



End Module
