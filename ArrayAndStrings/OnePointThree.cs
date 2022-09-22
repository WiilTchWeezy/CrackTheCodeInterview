using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointThree
    {
        //BIG O (2N)
        public string ReplaceString(string value)
        {
            var charArray = value.ToCharArray();
            for (int i = 0; i < value.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    string replacement = "%20";
                    int indexToReplace = i;
                    for (int j = 0; j < replacement.Length; j++)
                    {
                        charArray[indexToReplace] = replacement[j];
                        if (j < replacement.Length - 1)
                        {
                            for (int k = charArray.Length - 1; k > indexToReplace + j; k--)
                            {
                                charArray[k] = charArray[k - 1];
                            }
                        }
                        indexToReplace++;
                    }
                }
            }
            return new String(charArray);
        }

        //That works with the string in backwards but it's very similar to my solution
        public void ReplaceStringBookSolution(char[] str, int trueLength)
        {
            int spaceCount = 0, index, i = 0;
            for (i = 0; i < trueLength; i++)
            {
                if(str[i] == ' ')
                {
                    spaceCount++;
                }
            }
            index = trueLength + spaceCount * 2;
            if (trueLength < str.Length)
                str[trueLength] = '\0';
            for (i = trueLength -1; i >= 0; i--)
            {
                if(str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }
        }
    }
}
