using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_matrix
{
    internal class Matrix
    {
        public int row = 0;
        public int col = 0;
        public volatile int[,] matrix = { };

        public Matrix(int row, int col, bool random, int seed)
        {
            this.row = row;
            this.col = col;
            matrix = new int[row, col];
            if (random)
            {
                Random rnd = new Random(seed);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rnd.Next(10);
                    }
                }
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        public void multiplication(Matrix one, Matrix two, int row, int col)
        {
            for (int i = 0; i < one.matrix.GetLength(1); i++)
            {
                this.matrix[row, col] += one.matrix[row, i] * two.matrix[i, col];
            }

        }

        public void printMatrix(TextBox textBoxX)
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    textBoxX.AppendText(this.matrix[i, j].ToString() + " ");
                }
                textBoxX.AppendText(Environment.NewLine);
            }
        }

        //public void multiplication(Matrix one, Matrix two, int row, int col, int rowEnd, int colEnd)
        //{

        //    for (int i = row; i < one.matrix.GetLength(0); i++)
        //    {
        //        for (int j = col; j < two.matrix.GetLength(1); j++)
        //        {
        //            if (i == rowEnd && j == colEnd)
        //            {
        //                return;
        //            }

        //            for (int k = 0; k < one.matrix.GetLength(1); k++)
        //            {
        //                this.matrix[i, j] += one.matrix[i, k] * two.matrix[k, j];
        //            }


        //        }
        //    }
        //}

    }
}