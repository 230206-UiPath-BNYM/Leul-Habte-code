Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello Collections!")
        ' Arrays, Lists, Dictionaries

        '========Arrays==========
        ' Arrays are a homogenous collection of items stored in a contiguous memory space
        ' declare arrays by including () after the variable name
        dim fruits() as string = {"banana", "apple", "mango"}
        dim fruits2(3) as String
        ' arrays in vb are zero based
        fruits2(0) = "kiwi"
        fruits2(1) = "strawberry"
        fruits2(2) = "pineapple"

        ' enhanced for loop aka for each that is utilized to iterate over collections
        For Each fruit As String In fruits2
            Console.WriteLine(fruit)
        Next
        
        ' while arrays are cool and retrieving elements take o(1), it's statically sized

        '===========List==========
        ' Lists are ordered collections of homogenous items 
        ' like arrays are also index based , but unlike arrays can dynamically change size
        dim students as New List(of String)
        students.add("Leul")
        students.add("Neba")
        students.add("David")
        students.add("Dylan")

        For Each student As String In students
            Console.WriteLine(student)            
        Next

        students(3) = "Dylane"
        Console.WriteLine(students(3))

        '==========Dictionary========
        ' Dictionary is a collection of key value pairs
        ' access these values based on their keys

        dim gradeBook as new dictionary(of string, integer)
        gradeBook.Add("David", 95)
        gradeBook.Add("Leul", 100)
        gradeBook.Add("Neba", 200)

        'accessing dictionary value via its given key
        Console.WriteLine("Leul got a grade of {0}", gradeBook("Leul"))

        ' remove from dictionary/list use the remove method
        gradeBook.Remove("Leul")
        'iterating over dictionary
        For Each grade As KeyValuePair(of String, Integer) In gradeBook
            Console.WriteLine("{0} got a grade of {1}", grade.Key, grade.Value)
        Next
        
        
    End Sub
End Module