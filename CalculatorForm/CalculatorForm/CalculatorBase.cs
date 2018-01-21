using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForm
{
    public abstract class CalculatorBase
    {
        public double a, b, result;
        //constructor
        public CalculatorBase(double a, double b, double result) {

            this.a = a;
            this.b = b;
            this.result = result;
        }

        public abstract double Add();
        public abstract double Subtract();

        public abstract double GetResult();

    }
}
