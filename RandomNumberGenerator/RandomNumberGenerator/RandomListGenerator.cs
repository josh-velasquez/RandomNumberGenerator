using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumberGenerator
{
    public class RandomListGenerator
    {
        /// <summary>
        /// Generates a list of integers between min and max inclusive (increments of 1)
        /// </summary>
        /// <param name="min">minimum number</param>
        /// <param name="max">maximum number</param>
        /// <returns>List of numbers from min to max</returns>
        public static List<int> GenerateIntegerList(int min, int max)
        {
            if (min > max)
            {
                return new List<int>();
            }
            return Enumerable.Range(min, max).ToList();
        }

        /// <summary>
        /// Generates a random list based on a given list (default random algorithm uses modified Fisher-Yates
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">list to be randomized</param>
        /// <param name="algorithm">type of algorithm used for randomization</param>
        /// <returns></returns>
        public static List<T> GenerateRandomList<T>(List<T> list, RandomAlgorithm algorithm = RandomAlgorithm.FisherYatesShuffle)
        {
            if (list.Count == 0)
            {
                return new List<T>();
            }
            List<T> randomList = new List<T>();
            switch (algorithm)
            {
                case RandomAlgorithm.FisherYatesShuffle:
                    randomList = FisherYatesShuffleList(list);
                    break;

                default:
                    break;
            }
            return randomList;
        }

        /// <summary>
        /// Modified algorithm of Fisher-Yates shuffle.
        /// Takes the current value and swaps it with a random element that preceeds the value
        /// Runtime: O(n)
        /// </summary>
        /// <param name="list">list to be randomized</param>
        /// <returns>Shuffled list</returns>
        private static List<T> FisherYatesShuffleList<T>(List<T> list)
        {
            List<T> shuffledList = list.ToList();
            Random random = new Random();
            int randomIndex;
            T tempNum;
            int listLength = list.Count;
            for (int i = 0; i < listLength - 2; i++)
            {
                randomIndex = random.Next(i, listLength);
                tempNum = shuffledList[i];
                shuffledList[i] = shuffledList[randomIndex];
                shuffledList[randomIndex] = tempNum;
            }
            return shuffledList;
        }
    }
}