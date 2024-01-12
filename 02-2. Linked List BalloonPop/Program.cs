namespace _02_2._Linked_List_BalloonPop
{
    internal class Program
    {
        class Balloon
        {
            public int index; //몇 번째 풍선인지
            public int num; //풍선 안의 숫자
            public Balloon(int index, int num)
            {
                this.index = index;
                this.num = num;
            }
        }

        public static LinkedList<int> Solve(int N, int[] testCase)
        {
            LinkedList<int> result = new LinkedList<int>();
            LinkedList<Balloon> list = new LinkedList<Balloon>();

            //초기화
            for (int i = 0; i < testCase.Length; i++)
            {
                list.AddLast(new Balloon(i, testCase[i]));
            }

            bool isRight = false;//오른쪽인지 확인
            int move = 0; //몇칸 움직여야 하는지
            LinkedListNode<Balloon> node = list.First;
            LinkedListNode<Balloon> removeNode;
            while (list.Count > 0)
            {
                if (node.Value.num > 0)//양수면
                {
                    move = node.Value.num;
                    isRight = true;
                }else
                {
                    move = -1 * node.Value.num;
                    isRight = false;
                }
                removeNode = node;

                if (isRight)
                {
                    while( move-- > 0)
                    {
                        node = node.Next;
                        if (node == null)
                            node = list.First;
                    }
                }
                else
                {
                    while( move-- > 0)
                    {
                        node = node.Previous;
                        if (node == null)
                            node = list.Last;
                    }
                }

                result.AddLast(removeNode.Value.index + 1); //풍선 터트림. 결과값 저장
                list.Remove(removeNode);
            }
            
            return result;
        }


        static void PrintList(LinkedList<int> list)
        {
            Console.Write("터진 순서 : ");
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }
        }


        static void Main(string[] args)
        {
            //테스트 케이스 1
            int N1 = 5;
            int[] testCase1 = { 3, 2, 1, -3, -1 };
            PrintList(Solve(N1, testCase1));
        }

    }
}
