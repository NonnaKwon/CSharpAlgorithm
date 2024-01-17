using System.Xml.Linq;

namespace _06_1._웅찬이의_과제
{
    internal class Program
    {
        class MyData
        {
            public int d;
            public int w;
            public MyData(int d,int w)
            {
                this.d = d;
                this.w = w;
            }
        }


        static void Main(string[] args)
        {
            PriorityQueue<MyData, int> pq = new PriorityQueue<MyData, int>();
            

            int N = int.Parse(Console.ReadLine());
            int dayMax = 0;
            while(N-- > 0)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split(' ');
                MyData myData = new MyData(int.Parse(ss[0]), int.Parse(ss[1]));
                pq.Enqueue(myData, -1*myData.w);
                if(myData.d > dayMax)
                {
                    dayMax = myData.d;
                }
            }

            List<int> sc = new List<int>();
            for (int i = 0; i <= dayMax; i++)
                sc.Add(0);

            while(pq.Count > 0)
            {
                MyData md = pq.Dequeue();
                int day = md.d;
                while (0 < day && sc[day] != 0)
                    day--;
                if(0 < day && sc[day] == 0)
                    sc[day] = md.w;
            }

            int result = 0;
            for (int i = 0; i < sc.Count; i++)
                result += sc[i];
            Console.WriteLine(result);
        }
    }


}
