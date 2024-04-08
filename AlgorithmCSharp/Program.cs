using AlgorithmCSharp.Sort;
using BenchmarkDotNet.Running;

namespace AlgorithmCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortContext<QuickSortStrategy> quick = new SortContext<QuickSortStrategy>();
            //var arr = new int[] { 6, 1, 8, 3, 4, 5, 6 };
            //quick.Sort(arr);
            BenchmarkRunner.Run<SortBenchMark>();
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}