namespace _10._Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };

            // 순차탐색
            int indexOf = Array.IndexOf(array, 5);
            int result = Searching.SequentialSearch(array, 11);
            Console.WriteLine($"구현한 결과 위치 : {result}");


            // 이진탐색
            Console.WriteLine("정렬 전");
            int binarySearch = Array.BinarySearch(array, 2);
            Console.WriteLine($"정렬 전 이진탐색 결과 : {binarySearch}");
            Array.Sort(array);

            Console.WriteLine("정렬 후");
            binarySearch = Array.BinarySearch(array, 2);
            Console.WriteLine($"정렬 후 이진탐색 결과 : {binarySearch}");
        }
    }
}
