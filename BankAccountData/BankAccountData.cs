using System;

class BankAccountData
{
    static void Main()
    {
        string name = "Иван";
        string middlename = "Иванов";
        string lastname = "Иванов";
        decimal balance = 53324.57m;
        string bankname = "Bank Of America";
        string iban = "US03 USDG 9661 3100 1746 01";
        long cardnumber1 = 4744890014141269;
        long cardnumber2 = 4744890014141259;
        long cardnumber3 = 4744890014141299;


        Console.WriteLine("Holder name: {0} {1} {2}", name, middlename, lastname);
        Console.WriteLine();
        Console.WriteLine("Your balance is: ${0}", balance);
        Console.WriteLine();
        Console.WriteLine("Your credit card numbers are:");
        Console.WriteLine(cardnumber1);
        Console.WriteLine(cardnumber2);
        Console.WriteLine(cardnumber3);
        Console.WriteLine();

    }
}

