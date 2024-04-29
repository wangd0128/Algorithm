using AlgorithmCSharp.Sort;
using AlgorithmCSharp.Stack.LCR_024._反转链表;
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
            //BenchmarkRunner.Run<SortBenchMark>();
            var node = ListNode.CreateNode(1, 2, 3, 4, 5);
            Solution solution = new Solution();
            solution.ReverseList(node);
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}