using System;
using System.Collections.Generic;

namespace lb4
{
    public class List
    {
        int key;
        int value;

        public void Set(int KEY,int VALUE)
        {
            key = KEY;
            value = VALUE;
        }

        public string ToString()
        {
            return String.Format(key+" "+value);
        }
       
    }
    
}