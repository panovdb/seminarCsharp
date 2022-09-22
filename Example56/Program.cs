/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт
 номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] nums = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

PrintMatrix(nums);
System.Console.WriteLine("=================");

System.Console.Write(FindMinStrInArray(nums) + 1);
System.Console.WriteLine(" -я строка");

int FindMinStrInArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i, j];
        }
        array[i] = result;
    }
    return PositionMinStrInArray(array);
}

int PositionMinStrInArray(int[] array)
{
    int min = array[0];
    int positionMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            positionMin = i;
        }
    }
    return positionMin;
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