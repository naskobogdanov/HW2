using System;

class StringsAndObjects
{
    static void Main()
    {
        string hi = "Hello";
        string you = "World";
        object hiyou = hi+" "+you;
        string typecast = (string)hiyou;
        Console.WriteLine(typecast);
    }
}
