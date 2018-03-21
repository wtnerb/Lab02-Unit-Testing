using System;
using Xunit;
using atmApp;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void returnsBalance()
        {
            Assert.Equal(100.00, Program.GetBalance(1));
        }
    }
}
