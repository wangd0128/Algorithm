using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCSharp
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            var _next = next;
            var str = $"{val}";
            while (_next != null)
            {
                str += $" -> {_next.val}";
                _next = _next.next;
            }
            return str;
        }

        public static ListNode CreateNode(params int[] ints)
        {
            ListNode head = new ListNode(ints[0]);
            ListNode curr = head;
            for (int i = 1; i < ints.Length; i++)
            {
                curr.next = new ListNode(ints[i]);
                curr = curr.next;
            }
            return head;
        }
    }
}
