using System;
using System.Collections.Generic;

namespace AlgorithmCSharp.Stack.用队列实现栈
{
    public class MyStack
    {
        private Queue<int> que1 = new Queue<int>();
        private Queue<int> que2 = new Queue<int>();


        public MyStack()
        {

        }

        public void Push(int x)
        {
            var existsQue = que1.Count == 0 ? que2 : que1;
            existsQue.Enqueue(x);
        }

        public int Pop()
        {
            var emptyQue = que1.Count == 0 ? que1 : que2;
            var existsQue = que1.Count == 0 ? que2 : que1;
            var count = existsQue.Count;
            for (int i = 0; i < count - 1; i++)
            {
                var value = existsQue.Dequeue();
                emptyQue.Enqueue(value);
            }
            return existsQue.Dequeue();
        }

        public int Top()
        {
            var emptyQue = que1.Count == 0 ? que1 : que2;
            var existsQue = que1.Count == 0 ? que2 : que1;
            var count = existsQue.Count;
            int value = -1;
            for (int i = 0; i < count; i++)
            {
                value = existsQue.Dequeue();
                emptyQue.Enqueue(value);
            }
            return value;
        }

        public bool Empty()
        {
            var existsQue = que1.Count == 0 ? que2 : que1;
            return existsQue.Count == 0;
        }
    }
}
