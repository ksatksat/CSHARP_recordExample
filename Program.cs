using System;
/*
In ASP.NET Core (and C# in general), a record is a special kind 
of class introduced in C# 9.0. It is designed to be an immutable 
data object, which means once an instance of a record is created, 
its data cannot be changed. Records are particularly useful for 
defining data models with a focus on value equality, rather 
than reference equality.

What is a Record?
A record in C# is a concise way to create a class that holds data. 
It provides built-in functionality for equality checks, string 
representation, and immutability. Records are ideal for defining 
simple data containers.
*/
class Program
{
    static void Main(string[] args){
        //Immutability: Once created, the values of the properties cannot be changed.
        // person.FirstName = "Jane"; // This will cause a compilation error
        var person_1 = new Person("Maxat", "Id");
        var person_2 = new Person("Azat", "Id");
        var person_3 = new Person("Bek", "Id");
        Console.WriteLine(person_1 + " " + person_2 + " " + person_3);
        //Value Equality: Two instances of a record 
        //with the same data are considered equal.
        var person_4 = new Person("Maxat", "Id");
        bool areEqual = person_1 == person_4;//true
        Console.WriteLine(areEqual);
        //Deconstructing: You can deconstruct records into their individual components.
        var (firstName, lastName) = person_2;
        Console.WriteLine(firstName);
        /*With-expressions: You can create a copy of a record 
        with some properties changed using the with keyword.*/
        var person_5 = person_1 with {FirstName = "Max"};
        Console.WriteLine(person_5);
    }
    //Concise Syntax: Records provide a concise way to define data models.
    public record Person(string FirstName, string LastName);
}
/*output:
Person { FirstName = Maxat, LastName = Id } Person { FirstName = Azat, LastName = Id } Person { FirstName = Bek, LastName = Id }
True
Azat
Person { FirstName = Max, LastName = Id }
*/