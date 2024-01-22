namespace _09.Sorting
{
    internal class Program
    {
        static void SelectionSort(IList<int> list,int start,int end)
        {
            for(int i = start; i < end;i++)
            {
                int minIndex = i;
                for(int j = i+1; j < end;j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(list, minIndex, i);
            }
        }

        
        static void InsertionSort(IList<int> list,int start,int end)
        {
            for(int i= start+1; i<end;i++)
            {
                int insert = i;
                for(int j = i - 1; j >= 0; j--)
                {
                    if (list[i] < list[j])
                    {
                        insert = j;
                    }
                }

                for(int j=i;j>insert;j--)
                {
                    Swap(list, j, j - 1);
                }
            }
        }

        static void MergeSort(IList<int> list,int start,int end)
        {
            if (end - start <= 1)
                return;
            int mid = start + (end - start) / 2;
            MergeSort(list, start, mid);
            MergeSort(list, mid, end);
            Merge(list, start, mid, end);
        }


        static void Merge(IList<int> list,int start,int mid,int end)
        {
            List<int> newList = new List<int>();
            int leftIndex = start;
            int rightIndex = mid;

            while(leftIndex < mid && rightIndex < end)
            {
                if (list[leftIndex] < list[rightIndex])
                    newList.Add(list[leftIndex++]);
                else
                    newList.Add(list[rightIndex++]);
            }

            if (leftIndex < mid)
            {
                while (leftIndex < mid)
                    newList.Add(list[leftIndex++]);
            }
            else
            {
                while (rightIndex < end)
                    newList.Add(list[rightIndex++]);
            }

            for(int i=start;i<end;i++)
            {
                list[i] = newList[i-start];
            }
        }

        static void BubbleSort(IList<int> list,int start,int end)
        {
            for(int i=start;i<end;i++)
            {
                for(int j = 1 ; j < end-i; j++)
                {
                    if (list[j] < list[j - 1])
                        Swap(list, j, j - 1);
                }
            }
        }


        static void QuickSort(IList<int> list,int start,int end)
        {
            if (end - start <= 1)
                return;
            int pivot = end - 1;
            int rightIndex = pivot - 1;
            int leftIndex = start;
            while(leftIndex < rightIndex)
            {
                while (leftIndex < end && list[pivot] > list[leftIndex])
                    leftIndex++;
                while (rightIndex >= start && list[pivot] < list[rightIndex])
                    rightIndex--;
                if(leftIndex < rightIndex)
                {
                    Swap(list, rightIndex, leftIndex);
                }
            }
            Swap(list, pivot, leftIndex);
            QuickSort(list, start, leftIndex);
            QuickSort(list, leftIndex + 1, end);
        }

        static void HeapSort(IList<int> list,int start,int end)
        {
            //1. 루트와 맨끝 교환
            if(end - start <= 1) 
                return;
            Swap(list, start, end);

            //2. 최대힙 정렬해버려

        }


        static void Swap(IList<int> list, int index1,int index2)
        {
            int tmp = list[index1];
            list[index1] = list[index2];
            list[index2] = tmp;
        }


        static void Main(string[] args)
        {
            int[] ints1 = { 5, 86, 3, 487, 32, 0, 856, 147, 589, 631 };
            int[] ints2 = { 5, 86, 3, 487, 32, 0, 856, 147, 589, 631 };
            int[] ints3 = { 5, 86, 3, 487, 32, 0, 856, 147, 589, 631 };
            int[] ints4 = { 5, 86, 3, 487, 32, 0, 856, 147, 589, 631 };
            int[] ints5 = { 5, 86, 3, 487, 32, 0, 856, 147, 589, 631 };
            int[] ints6 = { 5, 86, 3, 487, 32, 0, 856, 147, 589, 631 };
            Console.Write("정렬 전 : ");
            PrintList(ints1);
            SelectionSort(ints1, 0, ints1.Length);
            InsertionSort(ints2, 0, ints2.Length);
            BubbleSort(ints3,0, ints3.Length);
            MergeSort(ints4, 0, ints4.Length);
            QuickSort(ints5,0, ints5.Length);
            HeapSort(ints6,0, ints6.Length);

            Console.Write("SelectionSort : "); PrintList(ints1);
            Console.Write("InsertionSort : "); PrintList(ints2);
            Console.Write("BubbleSort : "); PrintList(ints3);
            Console.Write("MergeSort : "); PrintList(ints4);
            Console.Write("QuickSort : "); PrintList(ints5);
            Console.Write("HeapSort : "); PrintList(ints6);
        }

        static void PrintList(IList<int> list)
        {
            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
