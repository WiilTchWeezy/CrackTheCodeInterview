using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview
{
    public static class OnePointOne
    {
        //BIG O - O(N²)
        public static bool HasUniqueChars(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                for (int j = i + 1; j < value.Length; j++)
                {
                    if (value[i] == value[j])
                        return false;
                }
            }
            return true;
        }

        //BIG O - O(log N)
        public static bool HasUniqueCharsBetterTimeComplexity(string value)
        {
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < value.Length; i++)
            {
                if (dic.ContainsKey(value[i]))
                    return false;
                else
                    dic.Add(value[i], i);
            }
            return true;
        }
    }
}
