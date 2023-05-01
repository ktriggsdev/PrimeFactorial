using System;
using System.Collections.Generic;

// This is my solution for the Prime Factorial challenge found here:
// https://github.com/karan/Projects

namespace PrimeFactorial
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            List<int> primeFactors = FindPrimeFactors(number);

            if (primeFactors.Count > 0)
            {
                Console.WriteLine("The prime factors of " + number + " are:");
                foreach (int factor in primeFactors)
                {
                    Console.Write(factor + " ");
                }
            }
            else
            {
                Console.WriteLine("No prime factors found for " + number);
            }
            
        }
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Finds all prime factors of a nunber in the for loop.
        static List<int> FindPrimeFactors(int n)
        {
            List<int> primeFactors = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                while (IsPrime(i) && n % i == 0)
                {
                    primeFactors.Add(i);
                    n = n / i;
                }
            }
            return primeFactors;
        }
    }
}
