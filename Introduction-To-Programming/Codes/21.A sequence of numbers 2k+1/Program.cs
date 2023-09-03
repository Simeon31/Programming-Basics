using System;

namespace _0403Ex05_Code.png
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int n = int.Parse(Console.ReadLine());
            while ( num <= n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
                         
                    
        }
    }
}
