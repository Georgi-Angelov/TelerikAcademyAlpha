using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_classes.Matrix
{
    public class Matrix<T> where T : struct, IComparable
    {
        private int rows;
        private int cols;
        private T[,] genericMatrix;

        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (value > 0)
                {
                    this.rows = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Rows must be > 0");
                }
            }
        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value > 0)
                {
                    this.cols = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Cols must be > 0");
                }
            }
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.genericMatrix = new T[this.rows, this.cols];
        }
        public Matrix(T[,] predefinedMatrix)
        {
            this.genericMatrix = predefinedMatrix;
            this.rows = genericMatrix.GetLength(0);
            this.cols = genericMatrix.GetLength(1);
        }

        public T this[int indexOfRows, int indexOfCols]
        {
            get
            {
                if (indexOfRows > this.rows - 1 || indexOfRows < 0)
                {
                    throw new IndexOutOfRangeException($"Invalid index: {indexOfRows}.");
                }

                if (indexOfCols > this.cols - 1 || indexOfCols < 0)
                {
                    throw new IndexOutOfRangeException($"Invalid index: {indexOfCols}.");
                }
                T result = this.genericMatrix[indexOfRows, indexOfCols];
                return result;
            }

            set { this.genericMatrix[indexOfRows, indexOfCols] = value; }
        }
    }
}
