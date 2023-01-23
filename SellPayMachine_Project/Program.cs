using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPayMachine_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            GiveChange();
        }

        static void GiveChange()
        {
            Console.WriteLine("Welcome to Delhaize");

            Console.WriteLine("intput the value of your shopping cart");

            double totalPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("insert the money in the Machine");

            double money = double.Parse(Console.ReadLine());

            double change = money - totalPrice;
            Console.WriteLine($"your change is {change} euro");

            while (change >= 200)
            {
                Console.WriteLine(" you received one bill of 200 euro");
                change -= 200;
            }
            while (change >= 100)
            {
                Console.WriteLine(" you received one bill of 100 euro");
                change -= 100;
            }
            while (change >= 50)
            {
                Console.WriteLine(" you received one bill of 50 euro");
                change -= 50;
            }
            while (change >= 20)
            {
                Console.WriteLine(" you received one bill of 20 euro");
                change -= 20;
            }
            while (change >= 10)
            {
                Console.WriteLine(" you received one bill of 10 euro");
                change -= 10;
            }
            while (change >= 5)
            {
                Console.WriteLine(" you received one bill of 5 euro");
                change -= 5;
            }

            while (change >= 2)
            {
                Console.WriteLine("you received one coin of 2 euro");
                change -= 2;
            }
            while (change >= 1)
            {
                Console.WriteLine(" you received one coin of 1 euro");
                change -= 1;
            }
            while (change >= 0.5)
            {
                Console.WriteLine(" you received one coin of 50 cent");
                change -= 0.5;
            }
            while (change >= 0.20)
            {
                Console.WriteLine(" you received one coin of 20 cent");
                change -= 0.20;
            }
            while (change >= 0.10)
            {
                Console.WriteLine(" you received one coin of 10 cent");
                change -= 0.10;
            }
            while (change >= 0.05)
            {
                Console.WriteLine(" you received one coin of 5 cent");
                change -= 0.05;
            }
            while (change >= 0.01)
            {
                Console.WriteLine(" you received one coin of 1 cent");
                change -= 0.01;
            }
        }
    }
}
