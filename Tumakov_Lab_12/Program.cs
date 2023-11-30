using System;

namespace Tumakov_Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // YPR 12.1
            Bank bank1 = new Bank("123", 1000.00m);
            Bank bank2 = new Bank("213", 500.00m);
            Bank bank3 = new Bank("123", 1000.00m);

            Console.WriteLine($"Проверка == \n{bank1.ToString()}  и {bank2.ToString()}\nРезультат:{bank1 != bank2}");
            Console.WriteLine($"Проверка == \n{bank1.ToString()}  и {bank3.ToString()}\nРезультат:{bank1 == bank3}");
            Console.WriteLine($"Проверка != \n {bank1.ToString()}   и  {bank3.ToString()} \nРезультат:{bank1 == bank3}");
            Console.WriteLine($"Проверка Equals \n {bank1.ToString()}   и  {bank3.ToString()} \nРезультат:{bank1.Equals(bank3)}");
            // DZ 12.2
            Complex complex1 = new Complex(2, 3);
            Complex complex2 = new Complex(4, 5);

            Complex sum = complex1 + complex2;
            Console.WriteLine("Сумма: " + sum);

            Complex product = complex1 * complex2;
            Console.WriteLine("Произведение: " + product);

            Complex difference = complex1 - complex2;
            Console.WriteLine("Разность: " + difference);

            bool isEqual = complex1 == complex2;
            Console.WriteLine("Равны ли числа? " + isEqual);
        }
    }
}
