using System;

namespace _13._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int readPagesForHour = int.Parse(Console.ReadLine());
            int deadline = int.Parse(Console.ReadLine());

            double timeReadingForAday = ((double)bookPages / readPagesForHour) / deadline;

            Console.WriteLine(timeReadingForAday);
        }
    }
}
