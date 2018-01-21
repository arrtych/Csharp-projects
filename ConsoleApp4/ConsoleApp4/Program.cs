using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PriceWithDiscount
    {
        public static Double checkForDiscount(double price, int widht, int height)
        {
            double newPrice = price;
            int square = widht * height;
            price = (square >= 10 && square < 20) ? price -= 2 : price -= 0;
            price = (square >= 20) ? price -= 4 : price -= 0;
            return price;
        }
    }
    class CalculatePrice
    {

        public static Double getPrice(int widht, int height, double pricePerMeter)
        {
            Double result = 0.00;
            result = (widht * height) * pricePerMeter;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wall width: ");
            int widht = Convert.ToInt16(Console.ReadLine());
            Console.Write("Wall height:  ");
            int height = Convert.ToInt16(Console.ReadLine());
            Console.Write("m2 price (in formt 0,00): ");
            double m2 = Convert.ToDouble(Console.ReadLine());

            //to calculate price with  parametrs from input
            double price = CalculatePrice.getPrice(widht, height, m2);          
           //to calculate price with discount
            double newPrice = PriceWithDiscount.checkForDiscount(price, widht, height);
            //Console.WriteLine("s" + widht * height);
            Console.WriteLine("Total price is " + newPrice + " euros.");

            Console.ReadKey();
        }
    }
    

}
