/*
 * @lc app=leetcode id=146 lang=csharp
 *
 * [146] LRU Cache
 */

// @lc code=start
public class LRUCache {
    Hashtable table;
    int length=0;
    public LRUCache(int capacity) {
        table =new Hashtable();
        length=capacity;
    }
    
    public int Get(int key) {
         if (key < length)
                return (int)table[key];
            return -1;
    }
    
    public void Put(int key, int value) {
        if(key<length){
            table.Add(key,value);
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

