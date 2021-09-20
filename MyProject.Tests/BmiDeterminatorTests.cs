using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyProject.Tests
{
    public class BmiDeterminatorTests
    {
        [Theory]
        [InlineData(10.0, BmiClassification.Underweight)]
        [InlineData(18.0, BmiClassification.Underweight)]
        [InlineData(8.0, BmiClassification.Underweight)]
        [InlineData(19.0, BmiClassification.Normal)]
        [InlineData(21.0, BmiClassification.Normal)]
        [InlineData(24.0, BmiClassification.Normal)]
        [InlineData(24.8, BmiClassification.Normal)]
        [InlineData(25.8, BmiClassification.Overweight)]
        [InlineData(28.8, BmiClassification.Overweight)]
        [InlineData(30.8, BmiClassification.Obesity)]
        [InlineData(32.8, BmiClassification.Obesity)]
        [InlineData(34.8, BmiClassification.Obesity)]
        [InlineData(34.9, BmiClassification.Obesity)]
        [InlineData(35.9, BmiClassification.ExtremeObesity)]
        [InlineData(55.9, BmiClassification.ExtremeObesity)]
        public void DetermineBmi_ForGivenBmi_ReturnsCorrectClassification(double bmi, BmiClassification classification)
        {
            // arrange
            BmiDeterminator bmiDeterminator = new BmiDeterminator();

            // act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            // assert
            Assert.Equal(classification, result);
        }

    }
}
