using System;
using Xunit;
using CalculatorApp;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            var calc = new Calculator();
            Assert.Equal(8, calc.Add(4,4));
        }

        [Fact]
        public void TestSubtract()
        {
            var calc = new Calculator();
            Assert.Equal(12, calc.Subtract(20, 8));
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(5, 0, 0)]
        [InlineData(10, -2, -20)]
        public void TestMultiply(float a, float b, float result)
        {
            var calc = new Calculator();
            Assert.Equal(result, calc.Multiply(a, b));

        }
    }
}
