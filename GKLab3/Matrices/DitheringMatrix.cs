using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.Matrices
{
    public static class DitheringMatrix
    {
        public readonly static int[,] Matrix2;

        static DitheringMatrix()
        {
            Matrix2 = new int[,] { { 0, 2 }, { 3, 1 } };
        }

        public static int[,] GetOnes(int n)
        {
            int[,] matrix = new int[n, n];
            for(int i=0;i< n;i++)
            {
                for(int j=0;j< n;j++)
                {
                    matrix[i, j] = 1;
                }
            }

            return matrix;
        }

        public static int[,] MultiplyMatrix(int a, int[,] m)
        {
            int n = m.GetLength(0);
            int[,] matrix = new int[n, n];

            for(int i=0;i<n;i++)
            {
                for(int j=0;j< n;j++)
                {
                    matrix[i, j] = m[i, j] * a;
                }
            }

            return matrix;
        }

        public static int[,] SumMatrices(int[,] m1, int a1, int[,] m2, int a2)
        {
            if(m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
            {
                throw new Exception("Matrices sizes don't match");
            }

            int[,] matrix = new int[m1.GetLength(0), m1.GetLength(1)];
            for (int i=0;i<m1.GetLength(0);i++)
            {
                for(int j=0;j<m1.GetLength(1);j++)
                {
                    matrix[i, j] = a1 * m1[i, j] + a2 * m2[i, j];
                }
            }

            return matrix;
        }

        public static int[,] MergeMatrices(int[,] m)
        {
            int n = m.GetLength(0);
            int[,] matrix = new int[n * 2, n * 2];
            int[,] leftUpperMatrix = MultiplyMatrix(4, m);
            int[,] rightUpperMatrix = SumMatrices(m, 4, GetOnes(n), 2);
            int[,] leftLowerMatrix = SumMatrices(m, 4, GetOnes(n), 3);
            int[,] rightLoweMatrix = SumMatrices(m, 4, GetOnes(n), 1);

            for(int i=0;i< n;i++)
            {
                for(int j=0;j< n;j++)
                {
                    matrix[i, j] = leftUpperMatrix[i, j];
                }
            }
            for(int i=0;i< n;i++)
            {
                for(int j=0;j< n;j++)
                {
                    matrix[i, j + n] = rightUpperMatrix[i, j];
                }
            }
            for(int i=0;i< n;i++)
            {
                for(int j=0;j< n;j++)
                {
                    matrix[i + n, j] = leftLowerMatrix[i, j];
                }
            }
            for(int i=0;i< n;i++)
            {
                for(int j=0;j< n;j++)
                {
                    matrix[i + n, j + n] = rightLoweMatrix[i, j];
                }
            }

            return matrix;
        }

        public static int[,] GetMatrix(int k, out int n)
        {
            n=2;
            while(n*n*k<256)
            {
                n *= 2;
            }
            int[,] matrix = Matrix2;

            while(matrix.GetLength(0)<n)
            {
                matrix = MergeMatrices(matrix);
            }

            return matrix;
        }
    }
}
