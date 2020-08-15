/*
 * @lc app=leetcode id=2 lang=javascript
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers = function(l1, l2) {
   var List=new ListNode(0,null);
   var head=List;

   var carry=0;
   while((l1 || l2)|| carry){
    let v1= l1 && l1.val;
    let v2=l2&&l2.val;
    let total=carry+v1+v2;
    carry=total>=10?1:0;
    head.next=new ListNode(total%10);
    l1=l1&&l1.next;
    l2=l2&&l2.next;
    head=head.next;
   }
   return List.next;
};
// @lc code=end

