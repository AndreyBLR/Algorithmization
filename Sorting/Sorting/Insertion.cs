using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Insertion<T> where T: IComparable
    {
        public T[] Sort(T[] input, SortingDirection direction)
        {
            var compareMode = direction == SortingDirection.Descending ? CompareMode.GreaterThan : CompareMode.LessThan;

            for (int i = 1; i < input.Length; i++)
            {
                var currentItem = input[i];

                var j = i - 1;

                while (j >= 0 && Compare(input[j], currentItem, compareMode))
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }

                input[j + 1] = currentItem;
            }

            return input;
        }

        private bool Compare(T item1, T item2, CompareMode compareMode)
        {
            if (compareMode == CompareMode.LessThan)
                return item1.CompareTo(item2) >= 0;

            return item1.CompareTo(item2) <= 0;
        }
    }
}
