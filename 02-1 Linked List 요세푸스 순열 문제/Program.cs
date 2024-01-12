using System.Collections.Generic;

namespace _02_1_Linked_List_요세푸스_순열_문제
{
    internal class Program
    {
        public static LinkedList<int> Josephus(int N,int K)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedList<int> result = new LinkedList<int>();
            for (int i = 1; i <= N; i++)
                list.AddLast(i);

            int dieCount = 1;
            while(true) //1명 남으면 종료
            {
                if (dieCount == K)
                {
                    dieCount = 1;
                    result.AddLast(list.First.Value); //제거됨
                    list.RemoveFirst();
                }
                else
                {
                    dieCount++;
                    LinkedListNode<int> first = list.First;
                    list.AddLast(list.First.Value); //제거 안됐으니까 뒤에 다시 붙임
                    list.RemoveFirst();
                }

                if(list.Count == 1)
                    break;
            }
            result.AddLast(list.First.Value);
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("사람 수 입력 : ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("몇 번째 사람을 제거? : ");
            int K = int.Parse(Console.ReadLine());

            LinkedList<int> result = Josephus(N, K);
            Console.Write("결과 : ");
            foreach (int i in result)
            {
                Console.Write(i+" ");
            }
        }
    }
}
