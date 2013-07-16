using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T>
        where T:struct,IComparable,IFormattable,IConvertible,IComparable<T>,IEquatable<T>
    {
        private int rows;
        private int cols;
        private T[,] data;

        public int Cols
        {
            get
            {
                return this.cols;
            }
            set
            {
                this.cols = value;
            }
        }

        public int Rows
        {
            get
            { 
                return this.rows;
            }
            set 
            {
                this.rows = value; 
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    return data[row, col];
                }
                else
                {
                    throw new Exception(String.Format("Cell ({0}, {1}) is invalid.", row, col));
                }
            }
            set
            {
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    data[row, col] = value;
                }
                else
                {
                    throw new Exception(String.Format("Cell ({0}, {1}) is invalid.", row, col));
                }
            }
        }

        public  Matrix(int rows, int cols)
        {
            if (rows<=0 || cols<=0)
            {
                throw new Exception(String.Format("The rows and the cols must be positive integer numbers."));
            }
            this.Rows = rows;
            this.Cols = cols;
            this.data = new T[rows, cols];
        }

        public Matrix(T[,] value)
        {
            if (value == null || value.GetLength(0) == 0 || value.GetLength(1) == 0)
            {
                throw new Exception("The two-dimensional initialization array must contain at least one item.");
            }

            this.rows = value.GetLength(0);
            this.cols = value.GetLength(1);
            data = (T[,])value.Clone();
        }

        #region Methods

        public static Matrix<T> MatrixMultiply(Matrix<T> matrix1,Matrix<T> matrix2)
        {
            if (matrix1==null || matrix2==null)
            {
                throw new InvalidOperationException();
            }

            if (matrix1.cols!=matrix2.rows || matrix2.cols!=matrix1.rows)
            {
                throw new Exception("The rows of one of the matrices must be equal to the cols of the other matrix.");
            }

            try
            {
                Matrix<T> result = new Matrix<T>(matrix1.rows, matrix2.cols);
                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        result[row, col] = default(T);
                        for (int i = 0; i < matrix1.cols; i++)
                        {
                            checked
                            {
                                result[row, col] += (dynamic)matrix1[row, i] * matrix2[i, col];
                            }
                        }
                    }
                }
                return result;
            }
            catch(OverflowException ex) 
            {
                throw new Exception("Multiplication resulted in an overflow.",ex);
            }
        }

        private static Matrix<T> Multiply(int c, Matrix<T> m)
        {
            if (m == null)
            {
                throw new Exception("Matrix is not initialized.");
            }

            try
            {
                Matrix<T> result = new Matrix<T>(m.rows, m.cols);

                for (int row = 0; row < m.rows; row++)
                {
                    for (int col = 0; col < m.cols; col++)
                    {
                        checked
                        {
                            result[row, col] = (dynamic)m[row, col] * c;
                        }
                    }
                }

                return result;
            }
            catch (OverflowException ex)
            {
                throw new Exception("Multiplication resulted in an overflow.", ex);
            }
        }

        private static Matrix<T> Add(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 == null || m2 == null)
            {
                throw new Exception("Matrices are not initialized.");
            }

            if (m1.rows != m2.rows || m1.cols != m2.cols)
            {
                throw new Exception("Matrices must have the same dimensions.");
            }

            try
            {
                Matrix<T> result = new Matrix<T>(m1.rows, m1.cols);

                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        checked
                        {
                            result[row, col] = (dynamic)m1[row, col] + m2[row, col];
                        }
                    }
                }

                return result;
            }
            catch (OverflowException ex)
            {
                throw new Exception("Addition resulted in an overflow.", ex);
            }
        }

        private string MatrixToString()
        {
            int row;
            int col;
            int maxLength = Int32.MinValue;
            for (row = 0; row < rows; row++)
            {
                for (col = 0; col < cols; col++)
                {
                    int length = data[row, col].ToString().Length;
                    if (maxLength < length)
                    {
                        maxLength = length;
                    }
                }
            }

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\r\n");

            for (row = 0; row < rows; row++)
            {
                stringBuilder.Append("\t|");

                for (col = 0; col < cols; col++)
                {
                    stringBuilder.Append(data[row, col].ToString().PadLeft(maxLength + 1, ' '));
                }

                stringBuilder.AppendFormat("{0,2}\r\n", '|');
            }

            return stringBuilder.ToString();
        }
        #endregion
    }
}
