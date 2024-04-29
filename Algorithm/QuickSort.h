#pragma once
template<class T>
class QuickSort
{
public:
    QuickSort() {}
    ~QuickSort()
    {}
    /*void quick(int arr[]) {
        int size = length(arr);
        quick(arr, 0, size - 1);
    }*/

private:
    //int length(T& arr)
    //{
    //    //cout << sizeof(arr[0]) << endl;
    //    //cout << sizeof(arr) << endl;
    //    return sizeof(arr) / sizeof(arr[0]);
    //}
    //void quick(T& arr, int start, int end) {
    //    if (start >= end) {
    //        return;
    //    }
    //    int reference = arr[start];
    //    int left = start;
    //    int right = end;
    //    bool IsRight = true;
    //    while (left < right)
    //    {
    //        if (IsRight)
    //        {
    //            if (arr[right] < reference)
    //            {
    //                arr[left] = arr[right];
    //                IsRight = !IsRight;
    //                left++;
    //            }
    //            else
    //            {
    //                right--;
    //            }
    //        }
    //        else
    //        {
    //            if (arr[left] > reference)
    //            {
    //                arr[right] = arr[left];
    //                IsRight = !IsRight;
    //                right--;
    //            }
    //            else
    //            {
    //                left++;
    //            }
    //        }
    //    }
    //    arr[left] = reference;
    //    quick(arr, start, left - 1);
    //    quick(arr, left + 1, end);
    //}
};


