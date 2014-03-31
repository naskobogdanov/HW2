using System;

class BooleanVariable
{
    static void Main()
    {
        string nasko = "male";
        string female = "female";
        bool isFemale = (nasko == female);
        Console.WriteLine("I am female. - {0}", isFemale);
    }
}

