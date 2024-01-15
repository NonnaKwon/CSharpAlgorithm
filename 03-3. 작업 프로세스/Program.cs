namespace _03_3._작업_프로세스
{
    internal class Program
    {
        public static int[] ProcessJob(int[] jobList)
        {
            int[] result = new int[jobList.Length];
            Queue<int> queue = new Queue<int>(jobList);

            int workTime = 8;
            int day = 1;
            int index = 0;
            while (queue.Count > 0)
            {
                int todayJob = queue.Peek();
                while (todayJob > workTime)
                {
                    todayJob -= workTime;
                    day++;
                    workTime = 8;
                }

                workTime -= todayJob;
                queue.Dequeue();
                result[index++] = day;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[] input = { 4, 4, 12, 10, 2, 10 };
            int[] result = ProcessJob(input);
            foreach (int num in result)
            {
                Console.Write(num + ",");
            }
        }
    }
}