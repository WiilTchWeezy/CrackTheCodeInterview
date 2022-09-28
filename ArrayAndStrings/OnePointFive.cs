using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointFive
    {
        //BIG O O(N log N) where N is the longest string
        #region SolutionByTry
        public bool OneOrZeroEditsLeft(string inputA, string inputB)
        {
            if (inputA.Equals(inputB))
                return true;
            int lenghtDiff = inputA.Length - inputB.Length;
            if (lenghtDiff < 0)
                lenghtDiff = lenghtDiff * -1;

            if (lenghtDiff > 1)
                return false;
            int charDiff = 0;
            if (inputA.Length == inputB.Length)
            {
                int totalDiff = 0;
                for (int i = 0; i < inputA.Length; i++)
                {
                    if (inputA[i] != inputB[i])
                        totalDiff++;
                }
                if (totalDiff > 1)
                    return false;
                else
                    return true;
            }
            string longerString = string.Empty;
            string smallerString = string.Empty;
            if (inputA.Length > inputB.Length)
            {
                longerString = inputA;
                smallerString = inputB;
            }
            else
            {
                longerString = inputB;
                smallerString = inputA;
            }

            for (int i = 0; i < longerString.Length; i++)
            {
                if (smallerString.Length <= i)
                {
                    smallerString = InsertCharOnDiff(i, smallerString, '@');
                    charDiff++;
                    continue;
                }
                if (longerString[i] != smallerString[i])
                {
                    smallerString = InsertCharOnDiff(i, smallerString, '@');
                    charDiff++;
                }
            }
            return charDiff == 1;
        }

        private string InsertCharOnDiff(int index, string inputString, char insertChar)
        {
            char[] outputChar = new char[inputString.Length + 1];
            char[] inputCharArray = inputString.ToCharArray();
            for (int i = 0; i < outputChar.Length; i++)
            {
                if (i == index)
                {
                    outputChar[i] = insertChar;
                }
                else if (i > index)
                {
                    outputChar[i] = inputCharArray[i - 1];
                }
                else
                {
                    outputChar[i] = inputCharArray[i];
                }
            }
            return new string(outputChar);
        }
        #endregion

        #region BookSolution
        public bool OneEditAway(string first, string second)
        {
            if (first.Length == second.Length)
            {
                return OneEditReplace(first, second);
            }
            else if (first.Length + 1 == second.Length)
            {
                return OneEditInsert(first, second);
            }
            else if (first.Length - 1 == second.Length)
            {
                return OneEditInsert(second, first);
            }
            return false;
        }

        public bool OneEditReplace(string s1, string s2)
        {
            bool foundDiff = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (foundDiff)
                        return false;
                    foundDiff = true;
                }
            }
            return true;
        }

        public bool OneEditInsert(string s1, string s2)
        {
            int index1 = 0;
            int index2 = 0;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                        return false;
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        } 
        #endregion
    }
}
