using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Andon";
        string middleName = "Valentinov";
        string lastName = "Milev";
        decimal balance = 1000M;
        string bankName = "DSKBank";
        string iban = "BG80 STSA 9200 0020 1396 76";
        ulong firstCreditCard = 38126944411267u;
        ulong secondCreditCard = 30168427051873u;
        ulong thirdCreditCard = 30119202343882u;
        Console.WriteLine("Account holder: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance: {0:C}", balance);
        Console.WriteLine("Bank's name: {0}", bankName);
        Console.WriteLine("IBAN number: {0}", iban);
        Console.WriteLine("First Credit Card : {0}", firstCreditCard);
        Console.WriteLine("Second Credit Card: {0}", secondCreditCard);
        Console.WriteLine("Third Credit Card : {0}", thirdCreditCard);
    }
}
