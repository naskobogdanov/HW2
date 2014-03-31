using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number and press Enter \n(use \",\"):");
        string entrNum1 = Console.ReadLine();

        Console.WriteLine("Please enter the second number and press Enter \n(use \",\"):");
        string entrNum2 = Console.ReadLine();

        float precise = 0.000001f;
        float floatEntrNum1 = (Convert.ToSingle(entrNum1)) * precise;
        float floatEntrNum2 = (Convert.ToSingle(entrNum2)) * precise;


        if ((floatEntrNum1 < floatEntrNum2) ^ (floatEntrNum1 > floatEntrNum2))
        {
            Console.WriteLine("\n ({0} ; {1}) equal = False \n\n", entrNum1, entrNum2);
        }

        if (floatEntrNum1 == floatEntrNum2)
        {
            Console.WriteLine("\n ({0} ; {1}) equal = True \n\n", entrNum1, entrNum2);
        }

        Console.WriteLine("Example1 ..........");
        float firF = 5.3f;
        float secF = 6.01f;

        float preFirF = (float)(firF * precise);
        float preSecF = (float)(secF * precise);

        if (preFirF == preSecF)
        {
            Console.WriteLine("({0} ; {1}) equal = True \n\n", firF, secF);
        }
        else
        {
            Console.WriteLine("({0} ; {1}) equal = False \n\n", firF, secF);
        }

        //  Second Example: 
        Console.WriteLine("Example2 ..........");
        double firD = 5.00000001d;
        double secD = 5.00000003d;

        float preFirD = (float)(firD * precise);
        float preSecD = (float)(secD * precise);

        if (preFirD == preSecD)
        {
            Console.WriteLine("({0} ; {1}) equal = True \n\n", firD, secD);
        }
        else
        {
            Console.WriteLine("({0} ; {1}) equal = False \n\n", firD, secD);
        }
    }
}
