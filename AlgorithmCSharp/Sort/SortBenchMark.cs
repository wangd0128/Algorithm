using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp.Sort
{
    [MemoryDiagnoser]
    public class SortBenchMark
    {
        public ISortStrategy quick_strategy;
        public int[] arr;

        [GlobalSetup]
        public void Init()
        {
            quick_strategy = new QuickSortStrategy();
            arr = new int[10] { 2, 3, 1, 4, 5, 10, 6, 7, 2, 3 };
        }

        [Benchmark]
        public void QuickSort() {
            quick_strategy.Sort(arr);
        }

        [Benchmark]
        public void ArraySort()
        {
            Array.Sort(arr);
        }
    }
}
