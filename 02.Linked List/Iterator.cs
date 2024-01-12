using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Linked_List
{
    internal class Iterator
    {
        void Main1()
        {
            List<int> list = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int> ();
            SortedSet<int> set = new SortedSet<int> (); //이진 탐색 트리
            
            for(int i=0;i<10;i++)
            {
                list.Add(i);
                linkedList.AddLast(i);
            }
            
            for(int i=0;i<list.Count;i++)
            {
                Console.Write($"{list[i]} ");
            }

            for(int i=0;i<linkedList.Count;i++)
            {
                //Console.Write($"{linkedList[i]} "); error! -> 인덱서로 접근 불가!
            }

            for(LinkedListNode<int> node = linkedList.First; node != null; node = node.Next)
            {
                Console.Write($"{node.Value}");
            }
            Console.WriteLine();

            foreach(int value in linkedList)
            {
                Console.WriteLine(value);
            }



        }
    }
}
