using System;
using Xunit;

namespace MyProject.Tests
{
    public class MetricBmiCalculatorTests
    {
        [Theory]
        [InlineData(100, 170, 34.6)]
        [InlineData(57, 170, 19.72)]
        [InlineData(70, 170, 24.22)]
        [InlineData(77, 160, 30.08)]
        [InlineData(80, 190, 22.16)]
        [InlineData(90, 190, 24.93)]
        public void CalculateBmi_ForGivenWeightAndHeight_ReturnsCorrectBmi(double weight, double height, double bmiResult)
        {
            // arrange

            MetricBmiCalculator calculator = new MetricBmiCalculator();

            // act

            double result = calculator.CalculateBmi(weight, height);

            // assert

            Assert.Equal(bmiResult, result);
        }

        [Theory]
        [InlineData(0, 190)]
        [InlineData(-5, 150)]
        [InlineData(-11, 150)]
        [InlineData(90, -150)]
        [InlineData(90, 0)]
        [InlineData(0, 0)]
        public void CalculateBmi_ForInvalidArguments_ThrowsArgumentException(double weight, double height)
        {
            // arrange

            MetricBmiCalculator calculator = new MetricBmiCalculator();

            // act 

            Action action = () => calculator.CalculateBmi(weight, height);

            // assert

            Assert.Throws<ArgumentException>(action);
        }
    }
}
