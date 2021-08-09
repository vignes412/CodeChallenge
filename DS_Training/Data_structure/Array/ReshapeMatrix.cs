using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public static class ReshapeMatrix
    {
        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length <= 0 && mat[0].Length <= 0) return mat;
            List<int> temp = new List<int>();
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                    temp.Add(mat[i][j]);
            }
            int[][] result = new int[r][];
            int count = 0;

            for (int i = 0; i < r; i++)
            {
                result[i] = new int[r<c?r:c];
                for (int j = 0; j < c && j<r; j++)
                {
                    
                    result[i][j] = temp[count];
                    count++;
                }
            }
            return result;
        }
    }
}
