using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp.Stack.LCR_024._反转链表
{

 
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }
            ListNode _prev = head;
            ListNode _curr = head.next;
            ListNode _next = head.next.next;

            _prev.next = null;
            while (_curr != null)
            {
                _curr.next = _prev;
                if(_next == null)
                {
                    break;
                }
                _prev = _curr;
                _curr = _next;
                _next = _next.next;
            }
            return _curr;
        }
    }
}
