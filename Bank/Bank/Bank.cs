using System;

namespace Bank
{
    public class Bank
    {
        private static int id_counts = 0;

        public int id { get; private set; }
        public decimal Balance { get; private set; }

        internal Bank()
        {
            id = id_counts++;
            Balance = 0;
        }

        internal Bank(decimal initialBalance)
        {
            id = id_counts++;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 10)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Нельзя добавлять меньше 10 у.е.");
            }
        }

        public void Transfer(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Нехватает денег!");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Аккаунт № {0}", id);
            Console.WriteLine("Баланс: {0}", Balance);
        }
    }
}
