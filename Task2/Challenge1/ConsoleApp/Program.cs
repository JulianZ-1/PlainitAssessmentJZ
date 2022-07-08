using System;
using System.Numerics;
using System.Collections.Generic;

namespace FIB
{
    class Program
    {
        private static Dictionary<int, BigInteger> calculationCache;
        private static BigInteger Fibonacci(int num)
        {
            BigInteger result = 0;

            // Check if the number is in the cache, if so return the value
            // ! Cache is used to avoid recalculating the same numbers
            // ! Massive performance could be boost if fibonacci sequence is large
            if (calculationCache.ContainsKey(num))
            {
                return calculationCache[num];
            }

            // Otherwise calculate the value and add it to the cache
            if (num == 1 || num == 2)
            {
                result = 1;
            }
            else if (num > 0)
            {
                result = Fibonacci(num - 1) + Fibonacci(num - 2);
                calculationCache.Add(num, result);
            }

            return result;
        }



        static void Main(string[] args)
        {
            BigInteger number = 0;
            calculationCache = new Dictionary<int, BigInteger>();
            // 1. Generate Fibonacci sequence
            List<BigInteger> fibSequence = new List<BigInteger>();
            for (int i = 1; i <= 1000; i++)
            {
                fibSequence.Add(Fibonacci(i));
            }
            //print the sequence
            //foreach (BigInteger i in fibSequence)
            //   Console.WriteLine(i);
            Console.Write("Please enter a number >> ");
            number = BigInteger.Parse(Console.ReadLine());
            
            if (fibSequence.Contains(number))
            {
                Console.WriteLine("This number is a FIB number, and it's at {0} postion", fibSequence.IndexOf(number));
            }
            else
            {
                Console.WriteLine("It's not a FIB number");
            }
        }
    }
}