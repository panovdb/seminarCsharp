/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int n = 9;
int min = 10;

PrintMatrix(FillMatrixCircle(n, min));

int[,] FillMatrixCircle(int n, int min)
{
    int[,] array = new int[n, n];
    int i = 0, j = 0;
    while (n != 0)
    {
        int k = 0;
        do { array[i, j++] = min++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = min++;
        for (k = 0; k < n - 1; k++) array[i, j--] = min++;
        for (k = 0; k < n - 1; k++) array[i--, j] = min++;

        ++i; ++j;
        if (n < 2) n = 0;
        else n = n - 2;
    }
    return array;
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