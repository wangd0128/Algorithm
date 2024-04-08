using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp.Sort
{
    public class QuickSortStrategy : ISortStrategy
    {

        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] arr, int start, int end) {
            if(start >= end)
            {
                return;
            }
            int reference = arr[start];
            int left = start;
            int right = end;
            bool isRight = true;
            while(left < right)
            {
                if (isRight)
                {
                    if (arr[right] < reference)
                    {
                        arr[left] = arr[right];
                        isRight = !isRight;
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
                else
                {
                    if (arr[left] > reference)
                    {
                        arr[right] = arr[left];
                        isRight = !isRight;
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            arr[left] = reference;

            Sort(arr, start, left - 1);
            Sort(arr, left + 1, end);
        }
    }
}
