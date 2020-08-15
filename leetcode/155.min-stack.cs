using System;
/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start
public class Node{
    public int data;
   public int min;
    public Node next;
    public Node(int val,int lmin)
    {
        data=val;
        min=lmin;
    }
}
public class MinStack {
    
    Node root;
    /** initialize your data structure here. */
    public MinStack() {
       
    }
    
     public void Push(int x)
    {
        if(root==null){
            root=new Node(x,x);
        }else{
            var newNode=new Node(x,Math.Min(x,root.min));
            newNode.next=root;
            root=newNode;
        }
    }
    public void Pop() {
      root=root.next;
    }
    
    public int Top() {
        return root.data;
    }
    
    public int GetMin() {
       return root.min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

