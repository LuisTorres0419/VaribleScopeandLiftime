Option Strict On
Option Explicit On
Option Compare Binary

Module VaribleScopeandLiftime

    Dim y As Integer

    Sub Main()
        'TestTwo()
        Dim z As String = "z in main"
        Dim newNumber As Integer
        'TestThree(z)
        'TestFour(z)
        newNumber = 10
        For i = 1 To 2 Step 1

            TestFive(newNumber)

        Next

        'TestFive(newNumber)
        Console.WriteLine(newNumber)

        Console.ReadLine()
    End Sub

    Sub TestFive(ByVal aNumber As Integer)
        Static result As Integer

        result += aNumber
        aNumber = result
        Console.WriteLine(result)



    End Sub


    Sub TestThree(ByVal anystring As String)

        Console.WriteLine(anystring)
        anystring = "not in main"
        Console.WriteLine(anystring)

    End Sub

    Sub TestFour(ByRef anystring As String)

        Console.WriteLine(anystring)
        anystring = "not in main"
        Console.WriteLine(anystring)

    End Sub

    Sub TestOne()
        Dim x As Integer
        y = 7I
        x = 42
        Console.WriteLine("x= " & CStr(x))
        Console.WriteLine("y= " & CStr(y))

    End Sub

    Sub TestTwo()
        Dim x As Integer
        Console.WriteLine("x= " & CStr(x))
        Console.WriteLine("y= " & CStr(y))

        x = 5I
        y = 4I
        Console.WriteLine("x= " & CStr(x))
        Console.WriteLine("y= " & CStr(y))

        TestOne()
        Console.WriteLine("x= " & CStr(x))
        Console.WriteLine("y= " & CStr(y))

        Console.ReadLine()
    End Sub
End Module
