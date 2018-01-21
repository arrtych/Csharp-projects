using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of seconds: ");
            int value = int.Parse(Console.ReadLine());
            SecondsConverter.Convert(value);
            Console.ReadKey();
        }
    }
    class SecondsConverter
    {
        public static void Convert (int number)
        {
            var timeSpan = TimeSpan.FromSeconds(number);
            int hr = timeSpan.Hours;
            int mn = timeSpan.Minutes;
            int sec = timeSpan.Seconds;
            Console.WriteLine("Hours: " + hr + " Minutes: " + mn + " Seconds: " + sec);
        }
    }
}
