using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public class MyLinkedList
    {
        public MyNode head = null;
        public int length = 0;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index <= length)
            {
                var temp = head;
                int counter = 0;
                while (temp != null)
                {
                    if (index == counter)
                        return temp.data;
                    temp = temp.next;
                    counter++;
                }
            }
            return -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            MyNode newNode = new MyNode(val);
            if (head == null)
            {
                head = newNode;
                length++;
                return;
            }
            newNode.next = head;
            head = newNode;
            length++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            MyNode newNode = new MyNode(val);
            if (head == null)
            {
                head = newNode;
                length++;
                return;
            }
            var temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            length++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > length) return;
            if (index == length)
            {
                this.AddAtTail(val);
                return;
            }
            var temp = new MyNode(-1);
            temp.next = head;
            var prev = temp;
            while (index > 0)
            {
                prev = prev.next;
                index--;
            }
            MyNode newNode = new MyNode(val);
            newNode.next = prev.next;
            prev.next = newNode;
            head = temp.next;
            length++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index >= length)
                return;
            else
            {
                MyNode dummy = new MyNode(-1);
                dummy.next = head;
                MyNode prev = dummy;

                while (index > 0)
                {
                    prev = prev.next;
                    index--;
                }

                prev.next = prev.next.next;
                head = dummy.next;
                length--;
            }
        }
    }
    public class MyNode
    {
        public int data;
        public MyNode next;
        public MyNode(int data, MyNode next = null)
        {
            this.data = data;
            this.next = next;
        }
    }
    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
