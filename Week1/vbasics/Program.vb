Imports System
'modules in vb are class like artifacts that contains helper method
'every module has exaclty one instance and does not need to be
'created or assigned to a variable
Module Program
'This is a main method, this is the starting point of the program
'two kinds of method in vb
'functions- return something
'subs - return nothing or void
    Sub Main(args As String())
    'This is the same as print statment for other languages
        Console.WriteLine("Hello World!")
'where you end the method, every time you have a method 
'its a closing point
'variables - holds data, reference in memory, placeholder
'with vb, we create variables using the dim keywords, 
'greeting variable ()
dim greeting as String =  greeter("casual")
Console.WriteLine(greeting)
' GuessingGame(1)
' Counter(3)
GuessingGamev2()
End Sub
' you set the datatype with the as keyword 
Function greeter(greeting_type as String) As String
        ' flow control statements, used to channel logic based on certain 
        ' conditions
        ' select case AKA switch
        Select Case greeting_type
            Case "casual"
                greeting_type = "'sup"
                Return greeting_type
            Case "business casual"
                Return "salutations!"
            Case "full business"
                Return "to whom it may concern"
            Case Else
                Return "hello"
        End Select
    End Function
    
    Sub GuessingGame(guess as Integer)
        ' We'll use the random class to generate a random number
        dim rnd as Random = new Random()
        dim mysteryNumber as integer = rnd.Next(1,2)
        ' we use <> to represent non equality ie !=
        ' if block: 
        If guess <> mysteryNumber Then 
            Console.WriteLine("Wrong guess :<")    
        Else Console.WriteLine("Good guess :>")
        End if
    End Sub

    Sub Counter(stopping_point as Integer)
        dim start as Integer = 0
        ' while loop
        While  start < stopping_point
            Console.WriteLine(start)
            start = start + 1
        End While 

        'for loop
        'the lower and upper bounds are included in the iteration
        For index As integer = 0 To stopping_point
            Console.WriteLine(index)
        Next
        
    End Sub
    Sub GuessingGamev2()
        ' create a new instance of the random class
        dim rnd as Random = new Random()
        dim mysteryNumber as Integer = rnd.Next(1,100)
        Console.WriteLine("Enter guess: ")
        dim guess as String = Console.ReadLine()
        ' integer struct has a method called Parse that converts strings to their
        ' numeric values 
        ' TODO: add exception handling 
        dim guessNum as Integer = 0
        Try
            guessNum = Integer.Parse(guess)
        Catch ex As Exception
            Console.WriteLine("input is invalid. try again")
        End Try
        
        
        While guessNum <> mysteryNumber
            ' we wanna keep guessing
            If guessNum < mysteryNumber Then
                Console.WriteLine("Too low")
            Else Console.WriteLine("Too high")
            End If
            Console.WriteLine("Enter guess: ")
            Try
                guessNum = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("invalid input, try again")
            End Try
        End While
        Console.WriteLine("Congratulations! You guessed correctly")

    End Sub
End Module
