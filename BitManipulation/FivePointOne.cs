using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.BitManipulation
{
    public class FivePointOne
    {
        public string BitInsertion(string binary, string binaryToInsert, int start, int end)
        {
            string outPut = string.Empty;
            for (int i = 0; i < binary.Length; i++)
            {
                if(i >= start && i < binaryToInsert.Length)
                {
                    outPut += binaryToInsert[i];
                }
                else
                {
                    outPut += binary[i];
                }
            }

            return outPut;
        }
    }
}
