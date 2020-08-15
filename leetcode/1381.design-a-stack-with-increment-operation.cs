/*
 * @lc app=leetcode id=1381 lang=csharp
 *
 * [1381] Design a Stack With Increment Operation
 */

// @lc code=start
public class CustomStack {
int[] stackIn;
    int top;
    int intLength;
    public CustomStack(int maxSize) {
        stackIn=new int[maxSize];
        intLength=maxSize;
        top=-1;
    }
    
    public void Push(int x) {
        if(top<intLength-1){
            stackIn[++top]=x;
        }
    }
    
    public int Pop() {
        if(top<intLength && top>-1){
            int value=stackIn[top--];
            return value;
        }
        return -1;
    }
    
    public void Increment(int k, int val) {
        for(int i=0;i<k;i++){
            if(i<=top){
                stackIn[i]+=val;
            }else{
                break;
            }
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */
// @lc code=end

