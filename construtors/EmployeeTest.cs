using System;

class EmployeeTest{

static void Main(){
    Console.WriteLine($"employees before started count {Employee.Count}");
    var e1 = new Employee("susan","baker");
    var e2 = new Employee("bob","seeker");

    Console.WriteLine($"employees after instantiation: {Employee.Count}");

    Console.WriteLine($"employee 1: {e1.FirstName} {e2.LastName}");
    Console.WriteLine($"employee 2: {e2.FirstName} {e2.LastName}");

    e1=null;
    e2=null;

}
}