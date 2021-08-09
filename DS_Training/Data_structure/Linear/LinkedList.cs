using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{

    public class LinkedList
    {
        public Node Head;
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data,Node next=null)
            {
                this.Data = data;
                this.Next = next;
            }
        }

        public LinkedList()
        {

        }
        public Node RemoveNthFromEnd(Node head, int n)
        {
            if (head == null)
                return null;

            Node dummyNode = new Node(-1),
                     tempNode1 = dummyNode,
                     tempNode2 = dummyNode;
            tempNode1.Next = head;

            for (int i = 1; i <= n + 1; i++)
                tempNode2 = tempNode2.Next;

            while (tempNode2 != null)
            {
                tempNode1 = tempNode1.Next;
                tempNode2 = tempNode2.Next;
            }

            tempNode1.Next = tempNode1.Next.Next;

            return dummyNode.Next;
        }
        public Node DeleteDuplicates(Node head)
        {
            while (head != null && head.Next != null)
            {
                if (head.Data == head.Next.Data)
                {
                    head.Next = head.Next.Next;
                    continue;
                }
                head = head.Next;
            }
            return head;
        }
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        public void DisplayAllNode()
        {
            var temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
