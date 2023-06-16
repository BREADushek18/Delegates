using OverOverload;
using System;

namespace MyExceptions
{
    public class MatrixException : Exception
    {
        public MatrixException() { }
        public MatrixException(string message) : base(message) { }
        public MatrixException(string message, Exception innerEception) : base(message, innerEception) { }
    }
    public class ObjectException : Exception
    {
        public ObjectException() { }
        public ObjectException(string message) : base(message) { }
        public ObjectException(string message, Exception innerEception) : base(message, innerEception) { }
    }
    static class MyExtensions
    {
        public static int[,] TransposeMatrix(this SquareMatrix sqMatrix)
        {
            int sizeOfMatrix = sqMatrix.SizeOfMatrix;
            int[,] resultMatrix = new int[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < sizeOfMatrix; ++row)
            {
                for (int column = 0; column < sizeOfMatrix; ++column)
                {
                    resultMatrix[column, row] = sqMatrix[row, column];
                }
            }

            return resultMatrix;
        }
        public static int TraceOfMatrix(this SquareMatrix sqMatrix)
        {
            int trace = 0;
            int sizeOfMatrix = sqMatrix.SizeOfMatrix;

            for (int row = 0; row < sizeOfMatrix; ++row)
            {
                trace += sqMatrix[row, row];
            }

            return trace;
        }
    }
}