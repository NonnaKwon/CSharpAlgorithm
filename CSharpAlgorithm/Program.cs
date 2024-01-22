namespace CSharpAlgorithm
{
    internal class Program
    {
        static int blue = 0, white = 0;

        static void Divide(List<List<int>> lists,int startH,int endH,int startW,int endW)
        {
            //전체가 다 똑같은지 보기
            int color = lists[startH][startW];
            if (endH - startH <= 1)
            {
                if (color == 0)
                    white++;
                else
                    blue++;
                return;
            }
            bool isSame = true;
            for (int i = startH; i < endH; i++)
            {
                for (int j = startW; j < endW; j++)
                {
                    if(color != lists[i][j])
                    {
                        isSame = false;
                        break;
                    }
                }
                if (!isSame)
                    break;
            }


            //만약 똑같으면 0인지 1인지에 따라 count++ , 종료
            if(isSame)
            {
                if (color == 0)
                    white++;
                else
                    blue++;
                return;
            }
            else
            {
                //리스트 네 부분으로 나눠서
                Divide(lists, startH, endH / 2, startW, endW / 2); //첫번째 부분
                Divide(lists, startH, endH / 2, endW / 2 , endW); //두번째 부분
                Divide(lists, endH / 2 , endH, startW, endW / 2);
                Divide(lists, endH / 2 , endH, endW / 2 , endW);
            }
        }


        static void Main(string[] args)
        {
            List<List<int>> lists = new List<List<int>>();

            //입력받기
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                List<int> list = new List<int>();
                string input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                for (int j = 0; j < N; j++)
                {
                    list.Add(int.Parse(inputs[j]));
                }
                lists.Add(list);
            }

            //출력
            Divide(lists,0,N,0,N);
        }
    }
}
