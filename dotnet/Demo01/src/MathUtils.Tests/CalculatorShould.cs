using System;
using FluentAssertions;
using Xunit;

namespace MathUtils.Tests
{
    public class CalculatorShould
    {
        [Fact]
        public void Sum_ANumberAndZero_ReturnsTheNumber()
        {
            int number = 10;
            var calculator = new Calculator();

            var result = calculator.Sum(number, 0);

            number.Should().Be(result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(4, 3, 1)]
        public void Divide_TwoNumbers_Successfully(int numberA, int numberB, int expectedValue)
        {
            var calculator = new Calculator();
            var result = calculator.Divide(numberA, numberB);

            result.Should().Be(expectedValue);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            int number = 10;

            var calculator = new Calculator();
            Action action = () => calculator.Divide(number, 0);

            action.Should().ThrowExactly<DivideByZeroException>();
        }
    }
}
