using System.Linq.Expressions;
namespace LinkedList
{
    public class Node{
        public int Data { get; set; }
        public Node Next {get;set;}
        public Node(int val=0,Node next=null)
        {
          Data=val;
          Next=next;  
        }
    }
}