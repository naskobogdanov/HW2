using System;

class NullValues 
{
    static void Main()
    {
        int? someInteger = null;
        double? someDouble = null;
        int? sumnullinteger = someInteger + 23;
        double? sumnulldouble = someDouble + 23;

        Console.WriteLine("Here is the null integer ==>"+someInteger);
        Console.WriteLine("Here is the null double ==>"+someDouble);
        Console.WriteLine(); 
        Console.WriteLine("Here is the sum of null integer + number==>"+sumnullinteger);
        Console.WriteLine("Here is the sum of null double + number==>"+sumnulldouble);
        Console.WriteLine();
    }
}

