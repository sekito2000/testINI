using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testProj2
{
    class Matrix
    {
        int[][] array;

        public Matrix(int rows, int cols)
        {
            this.array = new int[rows][];
            for (int i = 0; i < rows; ++i)
                this.array[i] = new int[cols];
        }

        public int this[int i, int j]
        {
            set { this.array[i][j] = value; }
            get { return this.array[i][j]; }
        }
    }
}
