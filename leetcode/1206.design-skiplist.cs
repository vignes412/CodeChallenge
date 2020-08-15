using System.Runtime.InteropServices;
/*
 * @lc app=leetcode id=1206 lang=csharp
 *
 * [1206] Design Skiplist
 */

// @lc code=start
public class Skiplist {
    public Node Root { get; set; }
    public int length  {get; set;}
    public Skiplist() {
        
    }
    
    public bool Search(int target) {
        
    }
    
    public void Add(int num) {
        if(Root==null){
            Root=new Node(num);
            return;
        }
        Node curr=Root;
        Node prev=Root;
        var newnode=new Node(num);
        while(curr!=null)
        {
            prev=curr;
            if(num<=curr.val)
                curr=curr?.next;
            else
                curr=curr?.next?.next;
        }


    }
    
    public bool Erase(int num) {
        
    }
}
public class Node{
    public int val { get; set; }
    public Node next { get; set; }
}

/**
 * Your Skiplist object will be instantiated and called as such:
 * Skiplist obj = new Skiplist();
 * bool param_1 = obj.Search(target);
 * obj.Add(num);
 * bool param_3 = obj.Erase(num);
 */
// @lc code=end

