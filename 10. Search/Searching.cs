using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Search
{
    internal class Searching
    {
        public static int SequentialSearch<T>(IList<T> list,T item)
        {
            for(int i=0;i<list.Count;i++)
            {
                if (list[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public static int BinarySearch<T>(IList<T> list,T item) where T : IComparable<T>
        {
            int low = 0;
            int high = list.Count - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;

                if (list[mid].CompareTo(item) < 0)
                {
                    low = mid + 1;
                }
                else if (list[mid].CompareTo(item) > 0)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

    }
}
