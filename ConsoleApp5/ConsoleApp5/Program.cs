using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    /*

    Example I/O:
    Enter   room    width:   5
    Enter   room    height: 2.5
    Enter   room    depth:3
    
    Floor   or  ceiling area    is  15  square  meters.
    Floor   and ceiling area    is   30 square  meters.
    Longest wall    area    is  12.5    square  meters.
    Shortest    wall    area    is  7.5 square  meters.
    Room    total   area    is  70  square  meters.
    Room    total   volume  is  37.5    cubic   meters.
    */
    public static int getsum(int a, int b)
    {
        int result = 0;
        result = a + b;
        return result;
    }
    public static double getFloorOrCeilingArea(double w, double d)
    {
        double result = 0.00;
        result = w * d;
        return result;
    }
    //put getFloorOrCeilingArea result into argument 
    public static double getFloorAndCeilingArea(double number)
    {
        double result = 0.00;
        result = number * 2;
        return result;
    }
    public static double getLongestWallArea(double w, double h)
    {
        double result = 0.00;
        result = w * h;
        return result;
    }
    public static double getShortestWallArea(double d, double h)
    {
        double result = 0.00;
        result = d * h;
        return result;
    }
    public static double getRoomTotalVolume(double w, double h, double d)
    {
        double result = 0.00;
        result = w * h * d;
        return result;
    }


    public static double getRoomTotalArea(double width, double height, double depth)
    {
        double result = 0.00;
        result = (((width * depth) * 2) + ((width * height) * 2) + ((height * depth) * 2));
        return result;
    }

    static void Main()
    {

        Console.Write("Enter room width: ");
        double w = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter room height: ");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter room depth: ");
        double d = Convert.ToDouble(Console.ReadLine());
        double result1 = getFloorOrCeilingArea(w, d);
        double result2 = getFloorAndCeilingArea(result1);
        double result3 = getLongestWallArea(w, h);
        double result4 = getShortestWallArea(d, h);
        double result5 = getRoomTotalVolume(w,h,d);
        double result6 = getRoomTotalArea(w,h,d);

        Console.WriteLine("\n");
        Console.WriteLine("Floor or ceiling area is " + result1 + " square meters.");
        Console.WriteLine("Floor and ceiling area is " + result2 + " square meters.");
        Console.WriteLine("Longest wall area is " + result3 + " square meters.");
        Console.WriteLine("Shortest wall area " + result4 + " square meters.");
        Console.WriteLine("Room total area is " + result6 + " square meters.");
        Console.WriteLine("Room total volume is " + result5 + " square meters.");
        Console.ReadKey();

    }
}