Imports System

Module Program
    Sub Main(args As String())
        Dim vstup As String
        Dim cislo As Integer
        Dim soucet As Integer = 0
        Do
            Console.Write("Zadej ��slo: ")
            vstup = Console.ReadLine

            If Integer.TryParse(vstup, cislo) Then
                If cislo < 10 Then
                    If cislo > 0 Then
                        For i = 1 To cislo
                            soucet = soucet + i
                        Next
                        Console.WriteLine($"Sou�et od 1 do {cislo} je {soucet}")
                    Else
                        Console.WriteLine("�islo nesm� b�t z�porn�!")
                    End If
                Else
                        Console.WriteLine("Zadej ��slo men�� ne� 10!")
                End If

            Else
                Console.WriteLine("Napi� jen cel� ��slo!")
                End If


        Loop



    End Sub
End Module
