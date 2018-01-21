using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForm
{
    public class ExtendedCalculator : Calculator
    {
        public ExtendedCalculator (double a, double b, double result) : base(a, b, result)

        {
        }
        public double Multiply()
        {
            return base.a * base.b;
        }

        public double Divide()
        {
            return base.a  / base.b;
        }

        public override double Add()
        {
            return base.Add();
        }       

        public override double Subtract()
        {
            return base.Subtract();
        }
        public override double GetResult()
        {
            return base.GetResult();
        }
    }
}
