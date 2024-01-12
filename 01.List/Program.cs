namespace _01.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하시오 : ");
            int num = int.Parse(Console.ReadLine());

            List<int> list = new List<int>(num);
            for (int i = 0; i <= num; i++)
            {
                list.Add(i);
            }
            list.Remove(0);

            PrintList(list);

            while (true)
            {
                Console.Write("숫자를 입력하시오(종료는 -1) : ");
                int input = int.Parse(Console.ReadLine());
                if (input == -1)
                    break;

                if (list.Contains(input))
                    list.Remove(input);
                else
                    list.Add(input);
            }
            PrintList(list);

        }

        static public void PrintList(List<int> list)
        {
            Console.WriteLine("==========List 요소들==========");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
