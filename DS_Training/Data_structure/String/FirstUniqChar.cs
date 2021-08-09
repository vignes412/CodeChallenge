using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure.String
{
    public static class FirstUniqChar
    {
        public static int Solution(string s)
        {
            var m = s.ToCharArray();
            bool unique = false;
            for (int i = 0; i < m.Length; i++)
            {
                for(int j = 0; j < m.Length; j++)
                {
                    if (m[i] == m[j] && i!=j)
                    {
                        unique = false;
                        break;
                    }
                    else
                    {
                        unique = true;
                    }
                }
                if (unique)
                    return i;
            }
            return -1;
        }
    }
}
