using System;
using Xunit;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4,4);
        }

        [Theory]
        [InlineData(2, 3, 5)]
        public void CanAddTwoIntegers(int a, int b, int expected)
        {
            var answer = a + b;
            Assert.Equal(expected, answer);
        }
    }

    
}
