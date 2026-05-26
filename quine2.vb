Module Quine
    Sub Main()
        Dim s As String = "Module Quine
    Sub Main()
        Dim s As String = {0}{1}{0}
        s = s.Replace({0}{2}{0}, {0}{0}{0})
        s = s.Replace({0}{3}{0}, {0}{1}{0})
        Console.WriteLine(s, Chr(34), s, Chr(34) & vbCrLf & Chr(34))
    End Sub
End Module"
        s = s.Replace(Chr(34) & vbCrLf & Chr(34), Chr(34) & Chr(34) & Chr(34))
        s = s.Replace(Chr(34) & "=" & Chr(34), Chr(34) & "&" & Chr(34))
        Console.WriteLine(s, Chr(34), s, Chr(34) & vbCrLf & Chr(34))
    End Sub
End Module
