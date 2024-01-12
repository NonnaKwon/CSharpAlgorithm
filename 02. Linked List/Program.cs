namespace _02._Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numLinks = new LinkedList<int>();
            while(true)
            {
                Console.Write("숫자를 입력하시오(0입력시 종료) : ");
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                    numLinks.AddFirst(input);
                else if (input > 0)
                    numLinks.AddLast(input);
                else
                    break;
                Console.Write("리스트 목록 : ");
                foreach (int link in numLinks)
                    Console.Write(link+" ");
                Console.WriteLine();
            }
        }

        
    }
}
