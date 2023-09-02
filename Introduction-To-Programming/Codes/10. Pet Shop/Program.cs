using System;

namespace _10._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int petShopDogs = int.Parse(Console.ReadLine());
            int neighbourPets = int.Parse(Console.ReadLine());

            double totalPriceForFood = petShopDogs * 2.50 + neighbourPets * 4;

            Console.WriteLine("{0} lv.", totalPriceForFood);
        }
    }
}
