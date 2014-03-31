using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("The value of \"a\" is: {0}", a);
        Console.WriteLine("The value of \"b\" is: {0}", b);
        Console.WriteLine();

        int c = a;
        a = b;
        b = c;

        Console.WriteLine("The new value of \"a\" is: {0}", a);
        Console.WriteLine("The new value of \"b\" is: {0}", b);

        
    }
}

