using System;
using Xunit;
using static tddpractice.Program;

namespace Testing123
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("$100.23", 100.234)]
        [InlineData("$100.00", 100)]
        public void BalanceFormat(string expected, double balance)
        {
            Assert.Equal(expected, GetBalance(balance));
        }

        [Theory]
        [InlineData("$52.23", 100.234, 48)]
        //[InlineData("$100.23", 100.234, 408)] moved try-catch. No longer testable.
        public void CanWithdraw(string expected, double current, double withdrawl)
        {
            Assert.Equal(expected, GetBalance(Withdraw(current, withdrawl)));
        }


        [Theory]
        [InlineData("$234.00", 100.2, 133.8)]
        [InlineData("$100.20", 100.2, 0.0001)]
        [InlineData("$100.21", 100.2, 0.009999)]
        public void CanDeposit(string expected, double balance, double deposit)
        {
            Assert.Equal(expected, GetBalance(Deposit(balance, deposit)));
        }

        [Theory]
        [InlineData("$52.23", false, 100.234, 48)] // allows good behavior
        [InlineData("$234.00", true, 100.2, 133.8)] // allows good behavior
        [InlineData("$100.20", true, 100.2, -33.8)] // no neg deposit
        [InlineData("$100.23", false, 100.234, 408)] // no withdraw bigger than balance
        [InlineData("$100.23", false, 100.234, -48)] // no neg withdraw
        public void CanChangeBalanceWithOverload (string expected, bool select, double balance, double transaction)
        {
            try
            {
                balance = ChangeBalance(select, balance, transaction);
            }
            catch
            {

            }
            Assert.Equal(expected, GetBalance(balance));
        }
    }
}
