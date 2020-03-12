Module Module1

    Sub Main()
        Console.WriteLine(Enumerable.Range(0, 1000).Where(Function(n) n Mod 3 = 0 Or n Mod 5 = 0).Sum())
        Console.ReadLine()
    End Sub

End Module
