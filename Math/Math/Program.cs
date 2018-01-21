using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        /*

        Behavior of the Program:
        - If one argument is provided, then square will be returned (a*a).
        - If two arguments are provided, then first method result will be multiplied by second argument
        (FirstMethod * b) / (a*a*b).
        - If three arguments are provided, then second method result will be divided by third argument.
        Here need to handle division by zero exception (SecondMethod / c) / (a*a*b/c).
        - If four arguments are provided, then third method result will be added fourth argument
        (ThirdMethod + d) / (a*a*b/c+d).
        - If five arguments are provided, then subtract fifth argument from fourth method (FourthMethod
        - e) / (a*a*b/c+d-e)

        */
        static void Main(string[] args)
        {
            Console.WriteLine(math(8));
            Console.WriteLine(math(2,3));
            Console.WriteLine(math(2,3,2));
            Console.WriteLine(math(2,3,0));
            Console.WriteLine(math(2,3,2,4));
            Console.WriteLine(math(2, 3, 2, 4,5));

            Console.ReadLine();

        }


        //to calculate square of number (a*a)
        public static int math(int number)
        {
            return number * number;
        }

        //to calculate with two arguments (a*a*b)
        public static int math(int number1, int number2)
        {
            return math(number1) * number2;
        }


        //to calculate with three arguments ( (a*a*b)/c )
        public static double math(int number1, int number2, int number3)
        {
            double result = 0;
            //handle exception to dividing by zero 
            try
            {
                if (number3 == 0)
                    throw new ArgumentException("Attempted to divide by zero.");
                result = math(number1, number2) / number3;
            }
            catch(ArgumentException e)
            {                
                Console.WriteLine(e.Message);
            }            
            return result;
        }

        //to calculate with four arguments ( ((a*a*b)/c) + d) 
        public static double math(int number1, int number2, int number3, int number4)
        {
            double result = math(number1, number2, number3) + number4;
            return result;
        }

        //to calculate with five arguments ( ((a*a*b)/c) + d - e) 
        public static double math(int number1, int number2, int number3, int number4, int number5)
        {
            double result = math(number1, number2, number3, number4) - number5;
            return result;
        }
    }
}
