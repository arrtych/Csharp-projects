using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---");
            Console.WriteLine("Enter employee name: ");
            String EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter basic hourly wage: ");
            int HWage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter working hours (day shift): ");
            int DShifts = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter working hours (night shift):");
            int NSHifts = int.Parse(Console.ReadLine());          

            CalculateSalary(EmployeeName, HWage,NSHifts,DShifts);
            Console.ReadKey();


        }
        public static int CalculateSalary(String name,int basicHourlyWage, int nightShiftHours,int dayShiftHours)
        {
            int result =(basicHourlyWage * dayShiftHours) + (nightShiftHours * (basicHourlyWage * 2));
            Console.WriteLine("");
            Console.WriteLine("Employee : " + name);
            Console.WriteLine("Salary: : " + result + " EUR");
            Console.WriteLine("Night hours: " + nightShiftHours);
            Console.WriteLine("Day hours: " + dayShiftHours);
            return result;
            
        }
    }
}
