namespace _10_1._BFS와_DFS
{
    internal class Program
    {
        static void DFS(IList<IList<int>> list,IList<bool> visited,int go)
        {
            visited[go] = true;
            Console.Write(go+" ");

            foreach(int num in list[go])
            {
                if (!visited[num])
                {
                    DFS(list,visited, num);
                }
            }
        }

        static void BFS(IList<IList<int>> list, IList<bool> visited, int go)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(go);
            visited[go] = true;

            while(q.Count > 0)
            {
                int num = q.Dequeue();
                Console.Write(num+" ");
                foreach (int next in list[num])
                {
                    if (!visited[next])
                    {
                        q.Enqueue(next);
                        visited[next] = true;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[][] arr = new int[8][];
            bool[] visited = new bool[8]
                { false,false,false,false,false,false,false,false};
            arr[0] = new int[] { 3 , 4};
            arr[1] = new int[] { 3, 5, 6 };
            arr[2] = new int[] { 6 };
            arr[3] = new int[] { 0, 1, 5, 7 };
            arr[4] = new int[] { 0, 6 };
            arr[5] = new int[] { 1, 3, 6, 7 };
            arr[6] = new int[] { 1, 2, 4, 6, 7 };
            arr[7] = new int[] { 3, 5, 6 };

            Console.Write("DFS 결과 : ");
            DFS(arr, visited, 0);

            Console.WriteLine();

            //다시 초기화
            for (int i=0;i<visited.Length;i++)
            {
                visited[i] = false;
            }

            Console.Write("BFS 결과 : ");
            BFS(arr, visited, 0);


        }
    }
}
