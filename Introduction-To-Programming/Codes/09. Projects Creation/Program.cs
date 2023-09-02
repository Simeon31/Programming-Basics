using System;

namespace _09._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfAchitecture = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int hoursToFinish = numberOfProjects * 3;
            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.",
                nameOfAchitecture, hoursToFinish,
                numberOfProjects);
        }
    }
}
