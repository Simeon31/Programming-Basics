using System;

namespace _12._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int endTerm = int.Parse(Console.ReadLine());
            double annualPerCentInterest = double.Parse(Console.ReadLine());

            double sum = depositSum + endTerm * ((depositSum * annualPerCentInterest) / 100) / 12;

            Console.WriteLine(sum);
        }
    }
}
