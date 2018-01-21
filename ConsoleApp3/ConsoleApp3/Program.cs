using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            Clock clock = new Clock(seconds);
            Console.WriteLine(clock.showClock());
            Console.ReadKey();
        }
    }
    class Clock{
        public int sec;
        public Clock(int seconds)
        {
            this.sec = seconds;
        }
        public  int addSeconds(int num){
            return (num % 3600) % 60;;
        }
        public int addMinutes(int num)
        {
            return (num % 3600) / 60;
        }
        public int addHours( int num)
        {
            return num / 3600;

        }
        public String showClock()
        {
            // String EmployeeName = Console.ReadLine();
            return addHours(sec) + ":" + addMinutes(sec) + ":" + addSeconds(sec);
        }

    }

}
