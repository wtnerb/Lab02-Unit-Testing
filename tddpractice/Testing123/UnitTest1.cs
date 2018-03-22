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
        public void CanWithdraw (string expected, double current, double withdrawl)
        {
            Assert.Equal(expected, GetBalance(Withdraw(current, withdrawl)));
        }
        

        [Theory]
        [InlineData("$234.00", 100.2, 133.8)]
        [InlineData("$100.20", 100.2, 0)]
        [InlineData("$100.20", 100.2, 0.0001)]
        [InlineData("$100.21", 100.2, 0.009999)]
        public void CanDeposit(string expected, double balance, double deposit)
        {
            Assert.Equal(expected, GetBalance(Deposit(balance, deposit)));
        }
    }
}
