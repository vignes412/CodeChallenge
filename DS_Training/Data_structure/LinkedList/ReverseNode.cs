using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
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
    }
    public class ReverseNodeKGroup
    {
        public ListNode ReverseKGroup2(ListNode head, int k)
        {
            if (head == null)
                return null;
            ListNode curr = head;
            ListNode prev = null;

            for (int i = 0; i < k; i++)
            {
                if (curr == null)
                {
                    return ReverseKGroup2(prev, i);
                }
                ListNode tmp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tmp;
            }

            head.next = ReverseKGroup2(curr, k);
            return prev;
        }
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var temp = head;
            int count = 0;
            ListNode test = new ListNode();
            ListNode final = new ListNode();
            while (temp != null)
            {
                if (count != k)
                {
                    var newNode = new ListNode(temp.val);
                    AddAtLast(test, newNode);
                    count++;
                    temp = temp.next;
                }
                if(count==k)
                {
                    AddAtLast(final, ReverseNode(test.next));
                    count = 0;
                    test = new ListNode();
                }
            }
            AddAtLast(final, test.next);
            Console.WriteLine(count);
            return final.next;
        }
        public void AddAtLast(ListNode head, ListNode toAdd)
        {

            if (head == null)
                head = toAdd;
            else
            {
                var temp = head;
                while (temp != null)
                {
                    if (temp.next == null)
                    {
                        temp.next = toAdd;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }
        public void SwapNode(ListNode a, ListNode b)
        {
            var temp = a.val;
            a.val = b.val;
            b.val = a.val;
        }
        public ListNode ReverseNode(ListNode head)
        {
            var temp = head;
            ListNode reversed = null;
            while (temp != null)
            {
                var newNode = new ListNode(temp.val, reversed);
                reversed = newNode;
                temp = temp.next;
            }
            return reversed;
        }
    }
}
