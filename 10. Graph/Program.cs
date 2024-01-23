namespace _10._Graph
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[][] solution1 = new int[8][];
            solution1[0] = new int[] { 2, 4 };
            solution1[1] = new int[] { 2, 5 };
            solution1[2] = new int[] { 0, 4, 5, 6 };
            solution1[3] = new int[] { 7 };
            solution1[4] = new int[] { 0, 7 };
            solution1[5] = new int[] { 1, 2 };
            solution1[6] = new int[] { 2 };
            solution1[7] = new int[] { 3, 4 };
            Print(solution1 );
        }

        static void Print(int[][] solution)
        {
            for(int i=0;i<solution.Length; i++)
            {
                Console.Write($"{i}번째 : ");
                for (int j = 0; j < solution[i].Length; j++)
                {
                    Console.Write(solution[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
