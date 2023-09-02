using System;

namespace _11._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqaureMeter = double.Parse(Console.ReadLine());

            double currentPrice = sqaureMeter * 7.61;
            double discount = currentPrice * 18 / 100;
            double finalPrice = currentPrice - discount;

            Console.WriteLine("The final price is: {0} lv.\nThe discount is: {1} lv.", finalPrice, discount);
        }
    }
}
