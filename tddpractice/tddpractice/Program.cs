using System;

namespace tddpractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string GetBalance (double balance)
        {
            string output = balance.ToString("C2");
            Console.WriteLine("Your account balance is {0}", output);
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
                Console.WriteLine("Error, cannot have negative balance");
                return balance;
            }
            return balance;
        }
    }
}
