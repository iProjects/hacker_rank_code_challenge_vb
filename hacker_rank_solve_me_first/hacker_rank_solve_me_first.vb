 
Imports System

Module hacker_rank_solve_me_first
    
    Public Sub Main()
        Console.WriteLine("hacker rank in vb <<<<<<<<<<!!!!!!!!!!!!>>>>>>>>>>>")
        solveMeFirst_function()
        read_input_and_write_output()
        data_types_function()
        sum_arrays_fucntion()
        Console.ReadLine()
    End Sub

    Function solveMeFirst(ByVal a As Integer, ByVal b As Integer) As Integer
        ' Hint: Type Return a+b below 
        Return a + b
    End Function

    Sub solveMeFirst_function()
        Console.WriteLine("enter two number to perform addition....")
        Dim a As Integer
        Dim b As Integer
        Dim sum As Integer
        a = Console.ReadLine()
        b = Console.ReadLine()
        sum = solveMeFirst(a, b)
        Console.WriteLine("{0} plus {1} equals {2}", a, b, sum)
    End Sub

    Sub read_input_and_write_output()
        Console.WriteLine("enter a string literal to see its output....")
        ' Create a String variable:
        Dim greeting As String

        ' Read value from stdin and save it to variable:
        greeting = Console.ReadLine()

        ' Print "Hello, World." to stdout:
        Console.WriteLine("Hello, World.")

        ' Write your code here; print the contents of the 'greeting' variable to stdout.
        Console.WriteLine("you entered [ {0} ]", greeting)
    End Sub

    Sub data_types_function()
        Dim i As Integer = 4
        Dim d As Decimal = 4.0
        Dim s As String = "HackerRank "
        'Declare second integer, double, and String variables.
        Dim int1, sum_int As Integer
        Dim decimal1, sum_decimal As Decimal
        Dim string1 As String
        'Read and save an integer, double, and String to your variables.
        Console.WriteLine("enter one integer to perform addition with {0} ....", i)
        int1 = Console.ReadLine()
        Console.WriteLine("enter one decimal to perform addition with {0} ....", d)
        decimal1 = Console.ReadLine()
        Console.WriteLine("enter string to perform concatenation....")
        string1 = Console.ReadLine()
        'Print the sum of both integer variables on a new line.
        sum_int = i + int1
        Console.WriteLine("[ {0} ] plus [ {1} ] equals [ {2} ]", i, int1, sum_int)
        'Print the sum of the double variables on a new line.
        sum_decimal = d + decimal1
        Console.WriteLine("[ {0} ] plus [ {1} ] equals [ {2} ]", d, decimal1, sum_decimal)
        'Concatenate and print the String variables on a new line
        'The 's' variable above should be printed first.
        Console.WriteLine("{0} {1}", s, string1)
    End Sub

    Sub sum_arrays_fucntion()

    End Sub

End Module















