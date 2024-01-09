using System;

public class Employee{

    public static int Count {get; private set;}
    public string FirstName{get;}
    public string LastName{get;}

    public Employee(string firstName, string lastName){
        FirstName = firstName;
        LastName = LastName;
        ++Count;
        Console.WriteLine("Employee counters" + $"{FirstName}{LastName}: Count= {Count}");
    }

}