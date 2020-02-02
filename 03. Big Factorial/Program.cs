using System;
using System.Numerics;

namespace _03._Big_Factorial
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;

            for (int i = 1; i <= number; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
