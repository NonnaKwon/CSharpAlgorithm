namespace _10._그래프_인접행렬_표현
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] solution1 = new bool[8, 8]
            {   //0 1 2 3 4 5 6 7
                { false,false,true,false,true,false,false,false},
                { false,false,true,false,false,true,false,false},
                { true,true,false,false,true,true,false,false},
                { false,false,false,false,false,false,false,true},
                { true,false,false,false,false,false,false,true},
                { false,true,true,false,false,false,false,false},
                { false,false,true,false,false,false,false,false},
                { false,false,false,true,true,false,false,false},
            };

            bool[,] solution2 = new bool[8, 8]
            {   //0 1 2 3 4 5 6 7
                { false,false,false,false,false,false,false,false},
                { false,false,false,false,false,false,false,false},
                { false,false,false,false,true,true,false,false},
                { false,true,false,false,false,true,false,true},
                { false,false,false,false,false,false,false,false},
                { false,true,false,false,false,false,false,false},
                { false,false,true,false,false,true,false,false},
                { false,false,false,false,false,false,true,false},
            };

            const int INF = int.MinValue;
            int[,] solution3 = new int[8, 8]
            {
                { INF,4,INF,INF,6,INF,INF,INF},
                { 4,INF,5,4,INF,8,INF,INF},
                { INF,5,INF,INF,9,INF,INF,INF},
                { INF,4,INF,INF,INF,INF,INF,INF},
                { 6,INF,9,INF,INF,INF,5,INF},
                { INF,8,INF,INF,INF,INF,INF,1},
                { INF,2,INF,INF,5,INF,INF,INF},
                { INF,INF,INF,INF,INF,1,INF,INF},
            };

        }
    }
}
