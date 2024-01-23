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


    }
}
