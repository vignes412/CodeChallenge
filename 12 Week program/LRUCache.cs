using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _12_Week_program
{
    public class LRUCache
    {
        Hashtable table;
        int length = 0;
        public LRUCache(int capacity)
        {
            table = new Hashtable();
            length = capacity;
        }

        public int Get(int key)
        {
            if (key < length)
                return (int)table[key];
            return -1;
        }

        public void Put(int key, int value)
        {
            if (key < length)
            {
                table.Add(key, value);
            }
        }
    }
}
