using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Sorting.Tests
{
    [TestFixture]
    public class InsertionTests
    {
        [Test]
        public void DescendingSort()
        {
            var nonSortedInput = GenerateNonSortedInput(-100, 100, 500);

            var insertionSort = new Insertion<int>();

            var result = insertionSort.Sort(nonSortedInput, SortingDirection.Descending);

            IsSorted(result, SortingDirection.Descending);
        }

        [Test]
        public void AscendingSort()
        {
            var nonSortedInput = GenerateNonSortedInput(-100, 100, 500);

            var insertionSort = new Insertion<int>();

            var result = insertionSort.Sort(nonSortedInput, SortingDirection.Ascending);

            IsSorted(result, SortingDirection.Ascending);
        }

        private int[] GenerateNonSortedInput(int minValue, int maxValue, int amount)
        {
            var result = new int[amount];

            var random = new Random();

            for (int i = 0; i < amount; i++)
            {
                result[i] = random.Next(minValue, maxValue);
            }

            return result;
        }

        private void IsSorted(int[] sortedInput, SortingDirection sortingDirection)
        {
            if (sortingDirection == SortingDirection.Ascending)
            {
                for (int i = 0; i < sortedInput.Length - 1; i++)
                {
                    Assert.LessOrEqual(sortedInput[i], sortedInput[i+1], "Ascending Sorting is Failed! There is Item in sorted sequence which is more than next one.");
                }
            }
            if (sortingDirection == SortingDirection.Descending)
            {
                for (int i = 0; i < sortedInput.Length - 1; i++)
                {
                    Assert.GreaterOrEqual(sortedInput[i], sortedInput[i + 1], "Descending Sorting is Failed! There is Item in sorted sequence which is less than next one.");
                }
            }
        }
    }
}
