using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Search
{
    internal class Graph
    {
        public class Node<T> //연결 그래프
        {
            public T vertex;
            public List<Node<T>> edge;
        }

        public class GraphNode<T> //가중치 그래프
        {
            public T vertex;
            public List<(Node<T>, int)> edge;
        }

        //양방향
        bool[,] matrixGraph1 = new bool[5, 5]
        {
            {false,false,false,false,true },
            {false,false,false,false,true },
            {false,false,false,false,true },
            {false,false,false,false,true },
            {false,false,false,false,true },
        };

        const int INF = int.MaxValue;
        int[,] matrixGraph2 = new int[5, 5]
        {
            {0,132,INF,57,INF },
            {0,132,INF,5,INF },
            {0,132,INF,321,INF },
            {0,132,INF,INF,INF },
            {0,132,INF,545,INF },
        };

        public static void DFS(bool[,] graph,int start,out bool[] visited,out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for(int i=0;i<graph.GetLength(0);i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }
            SearchNode(graph, start, visited, parents);
        }

        public static void SearchNode(bool[,] graph, int start,bool[] visited,int[] parents)
        {
            visited[start] = true;
            for(int i=0;i<graph.GetLength(0);i++)
            {
                if (graph[start,i] &&
                    visited[i]) //연결되어있는 정점이면서, 방문한적 없는 정점
                {
                    parents[i] = start;
                    SearchNode(graph,i, visited, parents);
                }
            }
        }


        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;

            while(queue.Count > 0 )
            {
                int next = queue.Dequeue();
                for(int i=0;i<graph.GetLength(0);i++)
                {
                    if (graph[start,i] && !visited[i])
                    {
                        visited[i] = true;
                        parents[i] = next;
                        queue.Enqueue(i);
                    }
                }
            }
        }

    }
}
