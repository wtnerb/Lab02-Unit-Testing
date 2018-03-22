using System;

namespace tddpractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Start assuming atm interaction and with $1000,000
            bool looping = true;
            double balance = 1000 * 1000;
            while (looping)
            {
                PrintMenu();
                string option = Console.ReadLine();
                if (option == "1") //get balance
                {
                    GetBalance(balance);
                }
                else if (option == "2" || option == "3")// withdraw or deposit
                {
                    balance = ChangeBalance(option == "2", balance);
                }
                else if (option == "4") // quit
                {
                    looping = false;
                }   
                else
                {
                    Console.WriteLine("That is not a menu option.");
                }
            }
            Console.WriteLine("Thanks for playing!");
        }

        /// <summary>
        /// Will get user input for withdaw/deposit and call appropriate method.
        /// </summary>
        /// <param name="select">true deposit, false withdraw</param>
        /// <param name="balance">starting balance</param>
        public static double ChangeBalance (bool select, double balance)
        {
            double amount = 0;
            string behavior = (select) ? "deposit" : "withdraw";
            try
            {
                Console.WriteLine($"How much would you like to {behavior}?");
                amount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("that isn't a valid number.");
            }
            return (select)
                 ? Deposit(balance, amount)
                 : Withdraw(balance, amount);
        }

        public static void PrintMenu()
        {
            //Console.Clear();
            Console.WriteLine("Which action would you like to take?\n" +
                "1. View Balance\n" +
                "2. Deposit\n" +
                "3. Withdraw\n" +
                "4. Quit");
        }

        public static string GetBalance (double balance)
        {
            string output = balance.ToString("C2");
            Console.WriteLine($"Your account balance is {output}");
            return output;
        }

        public static double Withdraw (double balance, double withdrawl)
        {
            try
            {
                if (balance - withdrawl < 0)
                {
                    throw new Exception("Cannot have negative balance");
                }
                balance -= withdrawl;
            }
            catch 
            {
                Console.WriteLine("You are not that rich.");
                return balance;
            }
            return balance;
        }

        public static double Deposit (double balance, double deposit)
        {
            return balance + deposit;
        }
    }
}
