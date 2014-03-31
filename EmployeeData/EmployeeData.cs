using System;

class EmployeeData
{
    static void Main()
    {
        string firstname = "Atanas";
        string lastname = "Bogdanov";
        sbyte age = 25;
        char gender = 'm';
        long personalID = 8306112507;
        int employeenumber = 27569999;

        Console.WriteLine("First Name: {0}", firstname);
        Console.WriteLine("Last Name: {0}", lastname);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Personal ID number: {0}", personalID);
        Console.WriteLine("Unique employee number: {0}", employeenumber);
    }
}
