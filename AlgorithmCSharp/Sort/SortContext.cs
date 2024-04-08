using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp.Sort
{
    public class SortContext<T> where T : ISortStrategy, new()
    {
        ISortStrategy sortStrategy;

        public SortContext()
        {
            this.sortStrategy = new T();
        }


        public void Sort(int[] arr)
        {
            sortStrategy.Sort(arr);
        }

    }
}
