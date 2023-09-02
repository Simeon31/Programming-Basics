using System;

namespace _16._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());
            double PerCentTakenArea = double.Parse(Console.ReadLine());

            double v = length * width * high;
            double neededWater = v - ((v * PerCentTakenArea) / 100);

            Console.WriteLine("{0}", neededWater / 1000);
        }
    }
}
