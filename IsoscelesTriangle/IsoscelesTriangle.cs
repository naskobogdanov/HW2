using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyright = '\u00a9';
        string firstline = copyright+" "+copyright+" "+copyright+" "+copyright;
        string secondline = " "+copyright+" "+" "+" "+copyright+" ";
        string thirdline = " "+" "+copyright+" "+copyright+" "+" ";
        string fourthline = " " + " " + " " + copyright + " " + " " + " ";
        Console.WriteLine(fourthline);
        Console.WriteLine(thirdline);
        Console.WriteLine(secondline);
        Console.WriteLine(firstline);
    }
}

