/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
   public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1==null && l2!=null)
            return l2;
        if(l2==null && l1!=null)
            return l1;
        if(l2==null && l1 ==null)
            return null;
        var temp =l1;
        while(temp!=null){
            if(temp.next==null){
                temp.next=l2;
                break;
            }
            temp=temp.next;
        }
        temp=l1;
        while(temp!=null){
            var temp1 =temp.next;
            while(temp1!=null){
                if(temp.val>temp1.val){
                    int value=temp.val;
                    temp.val=temp1.val;
                    temp1.val=value;
                }
                temp1=temp1.next;
            }
            temp=temp.next;
        }
        return l1;
    }
}
// @lc code=end

