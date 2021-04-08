using System;
using System.Collections.Generic;

namespace RandomNumberGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int min = 1;
            const int max = 10000;
            List<int> sortedList = RandomListGenerator.GenerateIntegerList(min, max);
            List<int> randomList = RandomListGenerator.GenerateRandomList(sortedList);
            PrintList(randomList);
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the values of a list
        /// </summary>
        /// <param name="randomNumbers"></param>
        private static void PrintList(List<int> randomNumbers)
        {
            foreach (int num in randomNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}