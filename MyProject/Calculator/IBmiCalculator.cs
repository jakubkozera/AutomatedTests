using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Calculator
{
    public interface IBmiCalculator
    {
        double CalculateBmi(double weight, double height);
    }
}
