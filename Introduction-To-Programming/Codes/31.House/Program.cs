using System;

namespace _0402Еx09_Code.png
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roof = n - 2;
            int roofTiles = 0;
            int floor = n / 2;
            int floorStars = n - 2;

            if (n % 2 == 0)
            {
                roof = 2;
                roofTiles = n / 2 - 1;
            }
            else
            {
                roof = 1;
                roofTiles = n / 2;
            }

            while (roofTiles >= 1)
            {
                Console.WriteLine($"{new String('-', roofTiles)}{new String('*', roof)}{new String('-', roofTiles)}");
                roof += 2;
                roofTiles--;
            }

            Console.WriteLine(new String('*', n));

            for (int i = 0; i < floor; i++)
            {
                Console.WriteLine($"|{new String('*', floorStars)}|");
            }
        }
    }
}
        

