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
        [InlineData("$100.23", 100.234, 408)]
        public void CanWithdraw (string expected, double current, double withdrawl)
        {
            Assert.Equal(expected, GetBalance(Withdraw(current, withdrawl)));
        }
    }
}
