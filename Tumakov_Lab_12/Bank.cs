namespace Tumakov_Lab_12
{
    public class Bank
    {
        readonly string number;
        private decimal balance;
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Bank bank)
            {
                if ((bank.Number == Number) && (bank.Balance == Balance))
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Bank bank1, Bank bank2)
        {
            return ((bank1.Number == bank2.Number) && (bank1.Balance == bank2.Balance));
        }
        public static bool operator !=(Bank bank1, Bank bank2)
        {
            return ((bank1.Number != bank2.Number) || (bank1.Balance != bank2.Balance));
        }
        public override string ToString()
        {
            return $" Счет № {number}, баланс {balance}";
        }
        public Bank()
        {
            number = string.Empty;
            balance = 0;
        }
        public Bank(string number)
        {
            this.number = number;
            balance = 0;
        }
        public Bank(decimal balance)
        {
            number = string.Empty;
            this.balance = balance;
        }
        public Bank(string number, decimal balance)
        {
            this.number = number;
            this.balance = balance;
        }
    }
}
