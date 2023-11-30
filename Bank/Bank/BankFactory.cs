using System;
using System.Collections.Generic;

namespace Bank
{
    public class BankFactory
    {
        private static Dictionary<int, Bank> accs = new Dictionary<int, Bank>();

        public static int CreateAccount()
        {
            Bank account = new Bank();
            accs.Add(account.id, account);
            return account.id;
        }

        public static int CreateAccount(decimal initialBalance)
        {
            Bank account = new Bank(initialBalance);
            accs.Add(account.id, account);
            return account.id;
        }

        public static void CloseAccount(int id)
        {
            if (accs.ContainsKey(id))
            {
                accs.Remove(id);
                Console.WriteLine("Аккаунт № {0} закрыт.", id);
            }
            else
            {
                Console.WriteLine("Аккаунт № {0} не существует.", id);
            }
        }

        public static void DisplayAllAccounts()
        {
            foreach (Bank account in accs.Values)
            {
                account.DisplayAccountInfo();
                Console.WriteLine();
            }
        }
    }
}
