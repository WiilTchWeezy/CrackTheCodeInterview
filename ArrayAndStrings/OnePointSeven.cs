using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointSeven
    {

        public string[][] RotateMatrix(string[][] matrix)
        {
            string[][] outPutArray = new string[matrix.Length][];
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    int novaColuna = (matrix[row].Length -1) - row;
                    int novaLinha = column;
                    if (outPutArray[novaLinha] == null)
                        outPutArray[novaLinha] = new string[matrix[row].Length];
                    outPutArray[novaLinha][novaColuna] = matrix[row][column];
                }
            }
            return outPutArray;
        }
    }
}
