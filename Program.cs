using System;
struct BankAccount
{
    public int AccountNumber;
    public string AccountType;
    public double Balance;
}

namespace BankAccountProgram
{
    class Program
    {
        enum BankAccountType
        {
            Текущий,
            Сберегательный
        }

        static void Main(string[] args)
        { 
            BankAccountType accountType = BankAccountType.Текущий;
            Console.WriteLine($"Тип банковского счета: {accountType}");
            BankAccount account;
        Console.WriteLine("Второе задание:");
        account.AccountNumber = 123456789;
        account.AccountType = "Checking";
        account.Balance = 1000.50;       
        Console.WriteLine("Номер счета: " + account.AccountNumber);
        Console.WriteLine("Тип счета: " + account.AccountType);
        Console.WriteLine("Баланс: " + account.Balance);

        
        }

    }
}
