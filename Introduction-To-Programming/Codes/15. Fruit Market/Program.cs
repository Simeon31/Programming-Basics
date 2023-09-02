using System;

namespace _15._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasQuantity = double.Parse(Console.ReadLine());
            double orangesQuantity = double.Parse(Console.ReadLine());
            double rosberriesQuantity = double.Parse(Console.ReadLine());
            double strawberriesQuantity = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            double rosberriesPrice = strawberriesPrice / 2;
            double orangesPrice = rosberriesPrice - (rosberriesPrice * 0.40);
            double bananasPrice = rosberriesPrice - (rosberriesPrice * 0.80);

            strawberriesQuantity *= strawberriesPrice;
            bananasQuantity *= bananasPrice;
            orangesQuantity *= orangesPrice;
            rosberriesQuantity *= rosberriesPrice;

            totalPrice = strawberriesQuantity + bananasQuantity + orangesQuantity + rosberriesQuantity;

            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
