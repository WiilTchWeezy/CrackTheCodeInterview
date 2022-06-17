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
    }
}
