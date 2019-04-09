using System;
using Testing.Services;
using Xunit;

namespace Testing.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculator_should_be_able_to_add_2_by_2()
        {
            // ARRANGE
            CalculatorService service = new CalculatorService();
            int x = 2, y = 2;
            int result;

            // ACT
            result = service.Add(x, y);

            //ASSERT
            Assert.Equal(4, result);
        }

        [Theory]
        [InlineData(2,2)]
        [InlineData(40,2)]
        public void Calculator_should_be_able_to_add(int x, int y)
        {
            // ARRANGE
            CalculatorService service = new CalculatorService();
            //int x = 2, y = 2;
            int result;
            int assertion = x + y;

            // ACT
            result = service.Add(x, y);

            //ASSERT
            Assert.Equal(assertion, result);
        }

    }


}
