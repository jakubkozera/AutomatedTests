using MyProject.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class BmiCalculatorFacade
    {
        private readonly UnitSystem _unitSystem;
        private readonly IBmiCalculator _bmiCalculator;
        private readonly BmiDeterminator _bmiDeterminator = new();

        private IBmiCalculator GetBmiCalculator(UnitSystem unitSystem)
            =>
                unitSystem switch
                {
                    UnitSystem.Imperial => new ImperialBmiCalculator(),
                    UnitSystem.Metric => new MetricBmiCalculator(),
                    _ => throw new NotImplementedException()
                };

        private string GetSummary(BmiClassification classification)
            => classification switch
            {
                BmiClassification.Underweight => "You are underweight, you should put on some weight",
                BmiClassification.Normal => "Your weight is normal, keep it up",
                BmiClassification.Overweight => "You are a bit overweight",
                BmiClassification.Obesity => "You should take care of your obesity",
                BmiClassification.ExtremeObesity => "Your extreme obesity might cause health problems",
                _ => throw new NotImplementedException(),
            };

        public BmiCalculatorFacade(UnitSystem unitSystem)
        {
            _unitSystem = unitSystem;
            _bmiCalculator = GetBmiCalculator(unitSystem);
        }

        public BmiResult GetResult(double weight, double height)
        {
            var bmi = _bmiCalculator.CalculateBmi(weight, height);
            var classification = _bmiDeterminator.DetermineBmi(bmi);

            return new BmiResult()
            { 
                Bmi = bmi, 
                BmiClassification = classification, 
                Summary = GetSummary(classification)
            };

        }
    }
}
