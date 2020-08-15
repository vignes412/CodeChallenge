using System.Linq;
using System.Numerics;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Collections;
/*
 * @lc app=leetcode id=225 lang=csharp
 *
 * [225] Implement Stack using Queues
 */

// @lc code=start
public class MyStack {
    Queue<int> qStack;

    /** Initialize your data structure here. */
    public MyStack() {
        qStack=new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        qStack.Enqueue(x);
        for(int i=0;i<qStack.Count-1;i++){
            qStack.Enqueue(qStack.Dequeue());
        }
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
      return qStack.Dequeue();
    }
    
    /** Get the top element. */
    public int Top() {
       return qStack.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
       return qStack.Count==0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

