namespace CSharpAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lists = new List<List<int>>();

            //입력받기
            int N = int.Parse(Console.ReadLine());
            for(int i=0;i<N;i++)
            {
                List<int> list = new List<int>();
                string input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                for(int j=0;j<inputs.Length; j++)
                    list.Add(int.Parse(inputs[j]));
                lists.Add(list);
            }


            //풀이
            for(int i=1;i<N;i++)
            {
                for(int j = 0; j < lists[i].Count;j++)
                {
                    if (lists[i - 1].Count == j)
                        lists[i][j] += lists[i - 1][j - 1];
                    else if (j == 0)
                        lists[i][j] += lists[i - 1][j];
                    else
                        lists[i][j] += lists[i - 1][j] > lists[i - 1][j - 1] ? lists[i - 1][j] : lists[i - 1][j - 1];
                }
            }

            int max = lists[0][0];
            for(int i = 0; i < lists[N-1].Count; i++)
            {
                if(max < lists[N-1][i])
                    max = lists[N - 1][i];
            }

            Console.WriteLine(max);

        }
    }
}
