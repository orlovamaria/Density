using System;

namespace Density
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the mass of the first body - ");
            double mass;
            if (!double.TryParse(Console.ReadLine(), out mass))
            {
                Console.WriteLine("Incorrect input. Program completed");
                return;
            }

            Console.Write("Enter the volume of the first body - ");
            double volume;
            if (!double.TryParse(Console.ReadLine(), out volume))
            {
                Console.WriteLine("Incorrect input. Program completed");
                return;
            }

            double density = mass / volume;
            Console.WriteLine($"Density of the first body - {density}");

            Console.Write("Enter the mass of the second body - ");
            double mass2;
            if (!double.TryParse(Console.ReadLine(), out mass2))
            {
                Console.WriteLine("Incorrect input. Program completed");
                return;
            }

            Console.Write("Enter the volume of the second body - ");
            double volume2;
            if (!double.TryParse(Console.ReadLine(), out volume2))
            {
                Console.WriteLine("Incorrect input. Program completed");
                return;
            }

            double density2 = mass2 / volume2;
            Console.WriteLine($"Density of the second body - {density2}");

            if (density > density2)
            {
                Console.WriteLine("The density of the first body is greater");
            }
            else
            {
                Console.WriteLine("The density of the second body is greater");
            }

        }
    }
}
