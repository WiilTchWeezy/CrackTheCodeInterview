using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointSix
    {
        //BIG O O(N)
        public string CompressString(string input)
        {
            StringBuilder outPut = new StringBuilder();
            var inputCharArray = input.ToCharArray();
            char lastChar = inputCharArray[0];
            int charCount = 0;
            for (int i = 0; i < inputCharArray.Length; i++)
            {
                if (lastChar != inputCharArray[i])
                {
                    if (charCount > 1)
                        outPut.Append($"{lastChar}{charCount}");
                    else
                        outPut.Append($"{lastChar}");
                    lastChar = inputCharArray[i];
                    charCount = 1;
                }
                else
                {
                    charCount++;
                }

                if(i == (inputCharArray.Length -1))
                {
                    if (charCount > 1)
                        outPut.Append($"{lastChar}{charCount}");
                    else
                        outPut.Append($"{lastChar}");
                }
            }
            return outPut.ToString();
        }
    }
}
