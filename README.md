C# Matrix program
---------------------------------------------
C# Program to perform Matrix Multiplication

Description
---------------------------------------------
The Following is the program of C#

This code allows to perform Multiplication between any 2 valid matrix. 

The following code is limited to perform Multiplication between 2x3 and 3x2 matrix with specific values.

The matrix size and it's values are changeable.

Here's how it works
---------------------------------------------

1. Consist of 2 dimensions 1st array with custom values as 2x3 matrix

2. Consist of 2 dimensions 2nd array with custom values as 3x2 matrix

3. Initialized the variables Row_1, column_1, Row_2, column_2 as the length of 1st, 2nd row and column for clarity in next steps

4. Initialization of 2 dimensions array as result with size in brackets as Row 1 and column 2

5. Using condition of if else as column 2 = row 1 to check whether is it possible to perform Multiplication

6. Use first loop as i for rows iterations with condition i < row 1 with i++ increment

7. Use 1st nested loop as j for columns iterations with condition i < column 2 with j++ increment

8. Use of result with dimensions as 0 to avoid getting previous output

9. Use 2nd nested loop to perform Multiplication and it's sum in this form result [i,j] += a[i,k] * b[k,j]

10. Again use of first nested loops of row and column one and use Console.Write to print result with following result[i,j] + "\t" for tab space and Console.WriteLine in outer loop to make it in exact same format as matrix
