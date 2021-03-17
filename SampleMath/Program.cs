using System;

namespace SampleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            double z = -7.6;
            Console.WriteLine("Max between x and y is:"+Math.Max(x,y));
            Console.WriteLine("Min between x and y is:" + Math.Min(x, y));
            Console.WriteLine("Absolute of z is:" + Math.Abs(z));
            Console.WriteLine("Square root of x is:" + Math.Sqrt(x));
            Console.WriteLine("Round Value of z is:" + Math.Round(z));
        }
    }
}
