Module Module1

    Sub Main()
        Dim name As String
        Dim marks As Integer
        FileOpen(1, My.Application.Info.DirectoryPath & "\Stfile.txt", OpenMode.Append)
        For x = 1 To 10
            Console.Write("enter name : ")
            name = Console.ReadLine()
            Console.Write("enter marks : ")
            marks = Console.ReadLine()
            If marks < 30 Then
                WriteLine(1, name)
            End If


        Next


    End Sub

End Module
