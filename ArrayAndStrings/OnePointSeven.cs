using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointSeven
    {
        //BIG O -> O(N²)
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

        #region BookSolution
        //BIG O -> O(N²)
        public bool Rotate(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length)
                return false;
            int n = matrix.Length;
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first][i]; //save top
                    //left -> top
                    matrix[first][i] = matrix[last - offset][first];

                    //bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    //right -> bottom
                    matrix[last][last - offset] = matrix[i][last];

                    //top -> right
                    matrix[i][last] = top;
                }
            }
            return true;
        } 
        #endregion
    }
}
