using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Search
    {

        public static int BinarySearch<T>(this T[] source, T item)
        {
            if (item == null)
                throw new ArgumentNullException();
            IComparer<T> comparer = Comparer<T>.Default;
            return source.BinarySearch<T>(item, comparer);
        }
        /// <summary>
        /// method of binary search.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">Source Array</param>
        /// <param name="item">Search item</param>
        /// <returns>Index element in array.</returns>
        public static int BinarySearch<T>(this T[] source, T item, IComparer<T> comparer)
        {
            if (item == null)
                throw new ArgumentNullException();
            if (comparer == null)
                comparer = Comparer<T>.Default;

            int left = 0, rigth = source.Length - 1, middle;

            while (left <= rigth)
            {
                middle = (rigth - left) / 2 + left;

                if (comparer.Compare(source[middle], item) == 0)
                    return middle;
                if (comparer.Compare(source[middle], item) > 0)
                    rigth = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }

        public static int BinarySearch<T>(this T[] source, T item, Comparison<T> comparer)
        {
            if (comparer == null)
                return source.BinarySearch<T>(item);
            return source.BinarySearch<T>(item, Comparer<T>.Create(comparer));
        }
    }
}
