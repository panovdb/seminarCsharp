/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

PrintMatrix(matrix1);
System.Console.WriteLine("********************");
PrintMatrix(matrix2);
System.Console.WriteLine("====================");

if (matrix1.GetLength(0) == matrix2.GetLength(1))
{
    System.Console.WriteLine("перемножение матриц возможно");
    PrintMatrix(MatrixMultiplication(matrix1, matrix2));
}
else System.Console.WriteLine("матрицы невозможно пермножить");

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < resultMatrix.GetLength(1); ++k)
            {
                temp += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = temp;
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine("]");
    }
}