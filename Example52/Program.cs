/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] nums = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
PrintArray(Average(nums));

double[] Average(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result += matrix[j, i];
        }
        array[i] = result / matrix.GetLength(0);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    foreach (var item in array)
    {
        System.Console.Write(Math.Round(item, 2) + "; ");
    }
    int origRow = Console.CursorTop;
    int origCol = Console.CursorLeft;
    Console.SetCursorPosition(origCol - 2, origRow);
    System.Console.Write("]");
}