using System;
using Xunit;
using static tddpractice.Program;

namespace Testing123
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100.234)]
        public void BalanceFormat(double balance)
        {
            Assert.Equal("$100.23" , GetBalance(balance));
        }

        [Fact]
        public void CanWithdraw ()
        {
            Assert.Equal("$52.23", GetBalance(Withdraw(100.234, 48)));
        }
    }
}
