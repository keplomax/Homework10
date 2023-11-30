using Bank;
using Construction;
using System;

public class Program
{
    public static void Main()
    {
        // YPR 11
        int account1 = BankFactory.CreateAccount();
        int account2 = BankFactory.CreateAccount(1000.0m);
        int account3 = BankFactory.CreateAccount(500.0m);

        Console.WriteLine("Акаунты:");
        BankFactory.DisplayAllAccounts();

        BankFactory.CloseAccount(account2);

        Console.WriteLine("Счета после закрытия:");
        BankFactory.DisplayAllAccounts();
        // DZ 11        
        Building building1 = Creator.CreateBuilding("Здание 1", "Улица 1", 5);
        Console.WriteLine($"Уникальный номер здания: {building1.UniqueNumber}");

        Building building2 = Creator.CreateBuilding("Здание 2", "Улица 2", 10);
        Console.WriteLine($"Уникальный номер здания: {building2.UniqueNumber}");

        Creator.RemoveBuilding(building2.UniqueNumber);
        Console.WriteLine("Здание 2 удалено");
    }
}