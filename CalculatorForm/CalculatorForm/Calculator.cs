using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForm
{
    public class Calculator : CalculatorBase
    {
        public Calculator(double a, double b, double result): base(a,b,result)
        {
        }

        //Add method implement
        public override double Add()
        {
            return base.a + base.b;
        }

        //Subtract method implement
        public override double Subtract()
        {
            return base.a - base.b;
        }

        public double Result
        {
            get
            {
                return base.result;
            }

            set
            {
                base.result = value;
            }
        }
        public override double GetResult()
        {
            return base.result;
        }
    }
}
