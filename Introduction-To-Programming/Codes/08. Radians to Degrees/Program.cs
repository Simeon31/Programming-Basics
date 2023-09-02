using System;

namespace _08._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = (rad * 180) / Math.PI;

            Console.WriteLine("{0}", Math.Round(deg));
        }
    }
}
