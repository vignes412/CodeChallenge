class MyLinkedList:
    
    def __init__(self):
        self.root=None
        self.length=0
        

    def get(self, index: int) -> int:
        temp=self.root
        count=0
        while(temp.next!=None):            
            if(index==count):
                return temp.val
            elif(temp.next.next==None and index==count+1):
                return temp.val
            temp=temp.next
            count+=1
            
        

    def addAtHead(self, val: int) -> None:
        newNode=Node(val)
        if(self.root==None):
            self.root=newNode
            self.length+=1
        else:
            temp=self.root
            self.root=newNode
            self.root.next=temp
            self.length+=1


        

    def addAtTail(self, val: int) -> None:
        newnode=Node(val)
        if(self.root==None):
            self.root=newnode
            self.length+=1
        else:
            temp=self.root
            while(temp.next!=None):
                temp=temp.next
            temp.next=newnode
            self.length+=1   

    def addAtIndex(self, index: int, val: int) -> None:
        newNode=Node(val)
        if(index<=self.length-1):
            temp=self.root
            count=1
            while(temp.next!=None):
                if(index==count):
                   newNode.next=temp.next
                   temp.next=newNode
                   self.length+=1
                   return
                elif(temp.next.next==None and index==count+1):
                    temp.next=newNode
                    self.length+=1
                    return
                temp=temp.next
                count+=1

            

    def deleteAtIndex(self, index: int) -> None:
        if(index<=self.length-1):
            temp=self.root
            count=1
            while(temp.next!=None):
                if(index==count):
                    if(temp.next.next!=None):
                        temp.next=temp.next.next
                        self.length-=1
                        return;
                    else:
                        temp.next=None
                        self.length-=1
                        return;
                temp=temp.next
                count+=1

        
class Node:
    def __init__(self,val=0,next=None):
        self.val=val
        self.next=next
    
def main():
    linkedList = MyLinkedList();
    linkedList.addAtHead(1);
    linkedList.addAtTail(3);
    linkedList.addAtIndex(1, 2);  
    linkedList.get(1);            
    linkedList.deleteAtIndex(1);  
    linkedList.get(1);   
    # a=Solution();
    # print(a.countNodes(root))

if __name__ == '__main__':
    main()
# Your MyLinkedList object will be instantiated and called as such:
# obj = MyLinkedList()
# param_1 = obj.get(index)
# obj.addAtHead(val)
# obj.addAtTail(val)
# obj.addAtIndex(index,val)
# obj.deleteAtIndex(index)