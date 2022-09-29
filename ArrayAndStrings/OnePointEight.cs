using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class ZeroFound
    {
        public int Row { get; set; }
        public int Column { get; set; }
    }
    public class OnePointEight
    {
        public int[][] SetColumnAndRowToZero(int[][] matrix)
        {
            int[][] outPutArray = new int[matrix.Length][];
            List<ZeroFound> founds = new List<ZeroFound>();
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    if (matrix[row][column] == 0)
                        founds.Add(new ZeroFound { Row = row, Column = column });
                }
            }
            foreach (var item in founds)
            {
                for (int column = 0; column < matrix[item.Row].Length; column++)
                {
                    matrix[item.Row][column] = 0;                        
                }
                int rows = 0;
                while(rows < matrix.Length)
                {
                    matrix[rows][item.Column] = 0;
                    rows++;
                }
            }
            return outPutArray;
        }

        #region BookSolutionOne
        public void SetZeros(int[][] matrix)
        {
            bool[] row = new bool[matrix.Length];
            bool[] column = new bool[matrix[0].Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            for (int i = 0; i < row.Length; i++)
            {
                if (row[i])
                    SetRowToZeros(matrix, i);
            }
            for (int i = 0; i < column.Length; i++)
            {
                if (column[i])
                    SetColumnsToZeros(matrix, i);
            }

        }
        void SetRowToZeros(int[][] matrix, int row)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                matrix[row][i] = 0;
            }
        }

        void SetColumnsToZeros(int[][] matrix, int column)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][column] = 0;
            }
        } 
        #endregion


    }
}
