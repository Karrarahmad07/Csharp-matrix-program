using System;

namespace Project_1
{
    internal class Matrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 7, 4, 9 },
                               { 2, 6, 0}};  // 2x3 Matrix

            int[,] matrix2 = { { 1, 9 },
                                { 4, 9 },
                                { 7, 0 }};  // 3x2 Matrix
            
            int row_1 = matrix.GetLength(0);
            int column_1 = matrix.GetLength(1);
            int row_2 = matrix2.GetLength(0);
            int column_2 = matrix2.GetLength(1); // Initialize variables as row and column as Length of rows & column

            
            int[,] result = new int[row_1, column_2]; // Store the result & the size of matrix

            
            if (column_1 == row_2) // In matrix columns of A = Rows of matrix B, used to check validity
            {
                for (int i = 0; i < row_1; i++) // First loop used for Rows
                {
                    for (int j = 0; j < column_2; j++) // Second loop used for Columns
                    {
                        result[i, j] = 0;   // To clear previous value or avoid null
                        for (int k = 0; k < column_1; k++)  // Third loop used for Multiplication & their sum
                        {
                            result[i,j] += matrix[i, k] * matrix2[k, j];
                        }
                       
                    }
                }

                
                for (int i = 0; i < row_1; i++)  // 1st loop of row
                {
                    for (int j = 0; j < column_2; j++)  // 2nd loop of column 
                    {
                        Console.Write(result[i, j] + "\t"); // Print values of matrix in sequence
                    }
                    Console.WriteLine(); // For new line
                }
            }
            else
            {
                Console.WriteLine("Invalid Matrix");
            }
        }
    }
}
