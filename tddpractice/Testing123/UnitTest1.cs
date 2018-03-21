using System;
using Xunit;
using tddpractice;

namespace Testing123
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(100, Program.GetBalance());
        }
    }
}
