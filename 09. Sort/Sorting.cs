using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Sort
{
    public class Sorting
    {
        public static void SelectionSrot(IList<int> list, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j <= end; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(list, i, minIndex);
            }
        }

        public static void Swap(IList<int> list, int leftIndex, int rightIndex)
        {
            int temp = list[leftIndex];
            list[leftIndex] = list[rightIndex];
            list[rightIndex] = temp;
        }


        public static void InsertionSort(IList<int> list,int start,int end)
        {
            for(int i= start; i <= end; i++)
            {
                for(int j=i;j>=1;j--)
                {
                    if (list[j-1] < list[j])
                    {
                        break;
                    }

                    Swap(list, j - 1,j);
                }
            }
        }


        public static void BubbleSort(IList<int> list,int start,int end)
        {
            for(int i= start; i<= end-1;i++)
            {
                for(int j=start;j<end-start;j++)
                {
                    if (list[j] > list[j+1])
                    {
                        Swap(list, j, j + 1);
                    }
                }
            }
        }
         
        //시간복잡도 - O(nlogn)
        public static void MergeSort(IList<int> list,int start,int end)
        {
            if (start == end)
                return;
            int mid = (start - end) / 2;
            MergeSort(list, start, mid);
            MergeSort(list, mid + 1, end);
            Merge(list, start, mid, end);
        }

        public static void Merge(IList<int> list,int start,int mid,int end)
        {
            List<int> sortedList = new List<int>();
            int leftIndex = start;
            int rightIndex = mid + 1;
            while(leftIndex <= mid && rightIndex <= end)
            {
                if (list[leftIndex] < list[rightIndex])
                {
                    sortedList.Add(list[leftIndex]);
                    leftIndex++;
                }else
                {
                    sortedList.Add(list[rightIndex]);
                    rightIndex++;
                }
            }

            if(leftIndex > mid)
            {
                for(int i=rightIndex; i<=end;i++)
                {
                    sortedList.Add(list[i]);
                }
            }
            else
            {
                for(int i=leftIndex;i<=mid;i++)
                {
                    sortedList.Add(list[i]);
                }
            }

            for(int i=0;i<sortedList.Count;i++)
            {
                list[start + i] = sortedList[i];
            }
        }

        public static void QuickSort(IList<int> list,int start,int end)
        {
            if (start >= end)
                return;
            int pivot = start;
            int left = pivot + 1;
            int right = end;

            while(left <= right)
            {
                while (list[left] <= list[pivot])
                    left++;
                while (list[right] > list[pivot] && left <= right)
                    right--;
                if (left < right)
                    Swap(list, left, right);
                else
                {
                    Swap(list, pivot, right);
                    break;
                }
            }

            QuickSort(list, start, right - 1);
            QuickSort(list, right + 1, end);
        }

        //시간복잡도 - O(nlogn) 최악에도 똑같이 nlogn
        //공간복잡도 - O(1)

        public static void HeapSort(IList<int> list)
        {
            for (int i = list.Count / 2 - 1; i >= 0; i--)
            {
                Heapify(list, i, list.Count);
            }

            for (int i = list.Count - 1; i > 0; i--)
            {
                Swap(list, 0, i);
                Heapify(list, 0, i);
            }
        }

        private static void Heapify(IList<int> list, int index, int size)
        {
            int left = index * 2 + 1;
            int right = index * 2 + 2;
            int max = index;
            if (left < size && list[left] > list[max])
            {
                max = left;
            }
            if (right < size && list[right] > list[max])
            {
                max = right;
            }

            if (max != index)
            {
                Swap(list, index, max);
                Heapify(list, max, size);
            }
        }
    }

}
