namespace BitShiftMatrix
{
    using System;
    using System.Numerics;
    class Program
    {
        static BigInteger sum = 1;
        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = Matrix(r, c);
            int pawnCurrentX = r - 1;
            int pawnCurrentyY = 0;


            int n = int.Parse(Console.ReadLine());
            string[] positions = Console.ReadLine().Split(' ');
            int[] positionsAsNums = new int[positions.Length];
            for (int i = 0; i < positionsAsNums.Length; i++)
            {
                positionsAsNums[i] = int.Parse(positions[i]);
            }
            Movements(matrix, pawnCurrentX, pawnCurrentyY, positionsAsNums, r, c, n);

        }

        private static void Movements(BigInteger[,] matrix, int pawnCurrentX, int pawnCurrentY, int[] positionsAsNums, int r, int c, int n)
        {
            int[] positionRowArray = new int[n];
            int[] positionColArray = new int[n];
            BigInteger sum = 0;
            for (int i = 0; i < positionsAsNums.Length; i++)
            {
                int currentNum = positionsAsNums[i];
                int coeff = Math.Max(r, c);
                int currentPositionRow = currentNum / coeff;
                int currentPositionCol = currentNum % coeff;
                positionRowArray[i] = currentPositionRow;
                positionColArray[i] = currentPositionCol;

            }
            for (int numberMoves = 0; numberMoves < n; numberMoves++)
            {
                int positionRow = positionRowArray[numberMoves];
                int positionCol = positionColArray[numberMoves];
                sum += SumToNextMovement(pawnCurrentX, pawnCurrentY, positionRow, positionCol, matrix);
                pawnCurrentX = positionRow;
                pawnCurrentY = positionCol;
            }
            sum = sum + 1;
            Console.WriteLine(sum);
        }

        private static BigInteger SumToNextMovement(int pawnCurrentX, int pawnCurrentY, int positionRow, int positionCol, BigInteger[,] matrix)
        {
            BigInteger currentSum = 0;
            if (pawnCurrentY <= positionCol)
            {
                for (int colMove = pawnCurrentY + 1; colMove <= positionCol; colMove++)
                {
                    currentSum += matrix[pawnCurrentX, colMove];
                    pawnCurrentY = colMove;
                    matrix[pawnCurrentX, colMove] = 0;
                }
            }
            else
            {
                for (int colMove = pawnCurrentY - 1; colMove >= positionCol; colMove--)
                {
                    currentSum += matrix[pawnCurrentX, colMove];
                    pawnCurrentY = colMove;
                    matrix[pawnCurrentX, colMove] = 0;
                }
            }

            if (pawnCurrentX <= positionRow)
            {
                for (int rowMove = pawnCurrentX + 1; rowMove <= positionRow; rowMove++)
                {
                    currentSum += matrix[rowMove, pawnCurrentY];
                    pawnCurrentX = rowMove;
                    matrix[rowMove, pawnCurrentY] = 0;
                }
            }
            else
            {
                for (int rowMove = pawnCurrentX - 1; rowMove >= positionRow; rowMove--)
                {
                    currentSum += matrix[rowMove, pawnCurrentY];
                    pawnCurrentX = rowMove;
                    matrix[rowMove, pawnCurrentY] = 0;
                }
            }

            return currentSum;
        }

        private static BigInteger[,] Matrix(int r, int c)
        {
            BigInteger[,] matrix = new BigInteger[r, c];
            matrix[r - 1, 0] = 1;
            for (int col = 1; col < c; col++)
            {
                matrix[r - 1, col] = matrix[r - 1, col - 1] * 2;
            }
            for (int row = r - 2; row >= 0; row--)
            {
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = matrix[row + 1, col] * 2;
                }
            }
            return matrix;
        }

    }
}