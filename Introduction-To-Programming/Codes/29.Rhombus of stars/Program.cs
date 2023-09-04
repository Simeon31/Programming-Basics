using System;

namespace _0402Еx06_Code.png
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaces= n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', spaces));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                spaces--;
            }
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', i));
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
            }


        }

    