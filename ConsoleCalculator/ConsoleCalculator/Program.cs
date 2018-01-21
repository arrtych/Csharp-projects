using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
             int value1, value2;
             double result;
            Console.WriteLine("Console Calculator.Enter any key to start (leave empty for exit)");
            string input = Console.ReadLine();
            while (input != string.Empty)
            {
                Console.WriteLine("Choose operation(+,-, *,/ and leave empty for exit) ");
                String op = Console.ReadLine();
             //   value2 = int.Parse(Console.ReadLine());
                if (op.Equals("+"))
                {
                    
                    Console.WriteLine("Add operand (leave empty for exit)");
                    if (Console.ReadLine() == string.Empty)
                    {
                        continue;
                        
                    }

                        value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Add operand (leave empty for exit)");
                        value2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current operations result is " + (value1 + value2));
                    
                        
                    
                    
                    
                }
                else if (op.Equals("-"))
                {
                    Console.WriteLine("Subtract operand (leave empty for exit)");
                    value1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Subtract operand (leave empty for exit)");
                    value2 = int.Parse(Console.ReadLine());
                    result = value1 - value2;
                    Console.WriteLine("Current operations result is " + result);
                }
                else if (op.Equals("*"))
                {
                    Console.WriteLine("Multiply operand (leave empty for exit)");
                    value1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Multiply operand (leave empty for exit)");
                    value2 = int.Parse(Console.ReadLine());
                    result = value1 * value2;
                    Console.WriteLine("Current operations result is " + result);
                }
                else if (op.Equals("/"))
                {
                    Console.WriteLine("Divide operand (leave empty for exit)");
                    value1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Divide operand (leave empty for exit)");
                    value2 = int.Parse(Console.ReadLine());
                    result = value1 / value2;
                    Console.WriteLine("Current operations result is " + result);
                }

              //  Console.ReadKey();
            }
            //while (!string.IsNullOrEmpty(Console.ReadLine()));

            


        }
    }
}
