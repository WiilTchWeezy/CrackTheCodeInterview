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

        //My solution follow the same type of thought but i only do one for and try to sum the ASCII values
        public bool IsPermutationBookSolution(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            int[] letters = new int[128];

            foreach (var aChar in a)
            {
                letters[aChar]++;
            }

            foreach (var bChar in b)
            {
                letters[bChar]--;
                if (letters[bChar] < 0)
                    return false;
            }
            return true;
        }
    }
}
