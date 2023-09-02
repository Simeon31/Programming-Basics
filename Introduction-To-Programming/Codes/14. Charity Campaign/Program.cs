using System;

namespace _14._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesPrice = cakes * 45;
            double waflesPrice = wafles * 5.80;
            double pancakesPrice = pancakes * 3.20;
            double earnsADay = (cakesPrice + waflesPrice + pancakesPrice) * confectioners;
            double TotalEarns = earnsADay * numberOfDays;
            double coveredFees = TotalEarns - (0.125 * TotalEarns);

            Console.WriteLine(coveredFees);
        }
    }
}
