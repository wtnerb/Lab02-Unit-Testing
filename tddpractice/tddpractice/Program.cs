using System;

namespace tddpractice
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // Start assuming atm interaction and with $1000,000
            bool looping = true;
            double balance = 1000 * 1000;
            while (looping)
            {
                PrintMenu();
                string option = Console.ReadLine();
                if (option == "1") // get balance
                {
                    GetBalance(balance);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else if (option == "2" || option == "3")// withdraw or deposit
                {
                    try
                    {
                        balance = ChangeBalance(option == "2", balance);
                    }
                    catch (Exception e)
                    {
                        Console.Write("An error occured because ");
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                    finally
                    {
                        Console.WriteLine("Thank you for choosing Virtual ATM!");
                    }
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
                // This function is called in a try catch block. The
                // catch prints the error message to the console. This exception
                // is more user friendly.
                throw new Exception("that isn't a valid number.");
            }

            if (amount < 0)
            {
                throw new Exception($"{behavior} amount cannot be negative.");
            }
            return (select)
                 ? Deposit(balance, amount)
                 : Withdraw(balance, amount);
        }

        //THIS OVERLOAD ONLY EXISTS FOR TESTING. IT MUST MIRROR THE ORIGINAL EVERYWHERE EXCEPT
        //REPLACE READLINE WITH TRANSACTION. OTHERWISE, TESTS WILL BE USELESS.
        public static double ChangeBalance(bool select, double balance, double transaction)
        {
            double amount = 0;
            string behavior = (select) ? "deposit" : "withdraw";
            try
            {
                Console.WriteLine($"How much would you like to {behavior}?");
                amount = transaction;// This line instead of ReadLine must be only difference in the overload.
            }
            catch
            {
                // This function is called in a try catch block. The
                // catch prints the error message to the console. This exception
                // is more user friendly.
                throw new Exception("that isn't a valid number.");
            }

            if (amount < 0)
            {
                throw new Exception($"{behavior} amount cannot be negative.");
            }
            return (select)
                 ? Deposit(balance, amount)
                 : Withdraw(balance, amount);
        }

        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Which action would you like to take?\n" +
                "1. View Balance\n" +
                "2. Deposit\n" +
                "3. Withdraw\n" +
                "4. Quit");
        }

        /// <summary>
        /// Reads balance as a currency and displays it on the console with some formatting
        /// </summary>
        /// <param name="balance">Current balance</param>
        /// <returns>string balance</returns>
        public static string GetBalance (double balance)
        {
            Console.Clear();
            string output = balance.ToString("C2");
            Console.WriteLine($"Your account balance is {output}");
            return output;
        }

        public static double Withdraw (double balance, double withdrawl)
        {
            if (balance - withdrawl < 0)
            {
                throw new Exception("you are not that rich.");
            }
            balance -= withdrawl;
            return balance;
        }

        public static double Deposit (double balance, double deposit)
        {
            balance += deposit;
            return balance;
        }
    }
}
