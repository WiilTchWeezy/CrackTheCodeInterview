using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointTwo
    {

        public bool IsPermuation(string a, string b)
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

        private string Swap(string value, int i, int j)
        {
            char temp;
            char[] valueCharArray = value.ToCharArray();
            temp = value[i];
            valueCharArray[i] = valueCharArray[j];
            valueCharArray[j] = temp;
            return new String(valueCharArray);

        }
    }
}
