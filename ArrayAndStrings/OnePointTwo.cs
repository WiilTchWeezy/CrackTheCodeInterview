using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointTwo
    {

        public bool IsPermutation(string a, string b)
        {
            if (a.Length != b.Length)
                return false;
            long strintACheckSum = 0;
            long strintBCheckSum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                strintACheckSum += a[i];
                strintBCheckSum += b[i];
            }
            if (strintACheckSum == strintBCheckSum)
                return true;
            else
                return false;
        }
    }
}
