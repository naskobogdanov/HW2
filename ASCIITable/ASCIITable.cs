using System;

class ASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            char code = (char)i;
            Console.WriteLine(code);
        }
    }
}

