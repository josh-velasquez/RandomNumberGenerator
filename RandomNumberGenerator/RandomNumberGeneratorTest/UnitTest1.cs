using NUnit.Framework;
using RandomNumberGenerator;
using System.Collections.Generic;

namespace RandomNumberGeneratorTest
{
    public class Tests
    {
        [Test]
        public void ManyNumbers_Test()
        {
            const int min = 1;
            const int max = 10;
            List<int> sortedNumbers = RandomListGenerator.GenerateIntegerList(min, max);

            List<int> randomNumbers0 = RandomListGenerator.GenerateRandomList(sortedNumbers);
            List<int> randomNumbers1 = RandomListGenerator.GenerateRandomList(sortedNumbers);

            Assert.AreEqual(randomNumbers0.Count, randomNumbers1.Count);
            Assert.AreNotEqual(randomNumbers0, randomNumbers1);
        }


        [Test]
        public void RandomNumber2Lists_Test()
        {
            const int min = 1;
            const int max = 10;
            List<int> sortedNumbers = RandomListGenerator.GenerateIntegerList(min, max);

            List<int> randomNumbers0 = RandomListGenerator.GenerateRandomList(sortedNumbers);
            List<int> randomNumbers1 = RandomListGenerator.GenerateRandomList(sortedNumbers);

            Assert.AreEqual(randomNumbers0.Count, randomNumbers1.Count);
            Assert.AreNotEqual(randomNumbers0, randomNumbers1);
        }

        [Test]
        public void RandomListDifferentType_Test()
        {
            List<string> stringList = new List<string> { "hello", "world", "coding", "is", "fun", "random", "test" };

            List<string> randomStringList0 = RandomListGenerator.GenerateRandomList<string>(stringList);
            List<string> randomStringList1 = RandomListGenerator.GenerateRandomList<string>(stringList);

            Assert.AreEqual(randomStringList0.Count, randomStringList1.Count);
            Assert.AreNotEqual(randomStringList0, randomStringList1);
        }

        [Test]
        public void DifferentMinMax_Test()
        {
            const int min = 543;
            const int max = 9694;
            List<int> sortedNumbers = RandomListGenerator.GenerateIntegerList(min, max);

            List<int> randomNumbers0 = RandomListGenerator.GenerateRandomList(sortedNumbers);
            List<int> randomNumbers1 = RandomListGenerator.GenerateRandomList(sortedNumbers);

            Assert.AreEqual(randomNumbers0.Count, randomNumbers1.Count);
            Assert.AreNotEqual(randomNumbers0, randomNumbers1);
        }

        [Test]
        public void MinGreaterThanMax_Test()
        {
            const int min = 300;
            const int max = 100;
            List<int> sortedNumbers = RandomListGenerator.GenerateIntegerList(min, max);

            List<int> randomNumbers0 = RandomListGenerator.GenerateRandomList(sortedNumbers);
            List<int> randomNumbers1 = RandomListGenerator.GenerateRandomList(sortedNumbers);

            Assert.AreEqual(randomNumbers0.Count, randomNumbers1.Count);
            // Should be both empty if invalid range
            Assert.AreEqual(randomNumbers0, randomNumbers1);
        }

        [Test]
        public void ManyRandomListGenerated_Test()
        {
            const int min = 1;
            const int max = 10000;
            const int NUM_LISTS = 10000;
            List<int> sortedNumbers = RandomListGenerator.GenerateIntegerList(min, max);
            List<List<int>> list = new List<List<int>>(NUM_LISTS);
            // Create list of random integer lists
            for (int i = 0; i < NUM_LISTS; i++)
            {
                List<int> randomList = RandomListGenerator.GenerateRandomList(sortedNumbers);
                list.Add(randomList);
            }

            // Check the whole list and ensure that there are no duplicates
            for (int i = 0; i < list.Count - 1; i++)
            {
                Assert.AreNotEqual(list[i], list[i + 1]);
            }
        }
    }
}