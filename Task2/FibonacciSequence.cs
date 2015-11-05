using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class FibonacciSequence
    {
        public static IEnumerable<int> Generate(int border)
        {
            if (border < 1)
                throw new ArgumentException("Number of elements should be greater than 1");
            if (border == 1)
                yield return 1;
            if (border == 2)
                yield return 1;
            int left = 1, rigth = 0;
            for (int i = 0; i < border; i++)
            {
                int temp = left + rigth;
                left = rigth;
                rigth = temp;
                yield return rigth;
            }
            yield break;
        }
    }
}
