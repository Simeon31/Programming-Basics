using System;

namespace _0403Ex04_Code.png
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2; 
            }
        }
    }
}
