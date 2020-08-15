using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace _12_Week_program.Stack
{
    public class MyStack
    {
        int[] root;
        int top=-1;
        public int length = 0;
        public bool isEmpty = true;
        int DEFAULT_MAX = 1000;
        public MyStack(int max)
        {
            root = new int[max];
            DEFAULT_MAX = max;
        }
        public MyStack()
        {
            root = new int[DEFAULT_MAX];
        }

        public void push(int val)
        {
            if (isEmpty)
            {
                length++;
                root[length-1] = val;
                top = val;
                isEmpty = false;
                return;
            }
            if (length + 1 > DEFAULT_MAX)
            {
                throw new StackOverflowException();
            }
            length++;
            root[length-1] = val;
            top = val;
            isEmpty = false;
            return;
        }
        public int pop()
        {
            if (length > -1)
            {
                int popVa = root[length - 1];
                root[length-1] = -1;
                length--;
                if (length == 0)
                {
                    top = -1;
                    isEmpty = true;
                }
                else
                {
                    top = root[length-1];
                    isEmpty = false;
                }
                return popVa;
            }
            return 0;
        }
        public int Top()
        {
            return top;
        }
        public void Clear()
        {
            Array.Clear(root, -1, length-1);
            isEmpty = true;
            length = 0;
            top = -1;
        }
    }
    public class CustomStack
    {
        int[] stackIn;
        int top;
        int intLength;
        public CustomStack(int maxSize)
        {
            stackIn = new int[maxSize];
            intLength = maxSize;
            top = -1;
        }

        public void Push(int x)
        {
            if (top < intLength-1)
            {
                stackIn[++top] = x;
            }
        }

        public int Pop()
        {
            if (top < intLength && top>-1)
            {
                int value = stackIn[top--];
                return value;
            }
            return -1;
        }

        public void Increment(int k, int val)
        {
            for (int i = 0; i < k; i++)
            {
                if (i <= top)
                {
                    stackIn[i] += val;
                }
                else
                {
                    break;
                }
            }
        }
    }

    
    public class MinStack
    {
        public class Node
        {
            public int data;
            public int min;
            public Node next;
            public Node(int val, int lMin)
            {
                data = val;
                min = lMin;
            }
        }

        Node root;
        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {
            if (root == null)
            {
                root = new Node(x, x);
            }
            else
            {
                var newNode = new Node(x, Math.Min(x, root.min));
                newNode.next = root;
                root = newNode;
            }
        }
        public void Pop()
        {
            root = root.next;
        }

        public int Top()
        {
            return root.data;
        }

        public int GetMin()
        {
            return root.min;
        }
    }
}
