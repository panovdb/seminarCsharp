/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array;
int m = 3;
int n = 4;
int minRandom = 11;
int maxRandom = 22;
array = CreateMatrix(m, n, minRandom, maxRandom);
PrintMatrix(array);
System.Console.WriteLine("=======");
int[] num = {4, 65, 765, 34, 3};
PrintMatrix(SortRowMatrix(array));


int[,] CreateMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRandom, maxRandom + 1);
        }

    }
    return array;

}

int[,] SortRowMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] array = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i, j];
        }
        array = SortArray(array);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = array[j];
        }
    }
    return matrix;

}


int[] SortArray(int[] arr)
{
 int temp = 0;

for (int write = 0; write < arr.Length; write++) {
    for (int sort = 0; sort < arr.Length - 1; sort++) {
        if (arr[sort] < arr[sort + 1]) {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
        }
    }
}
    return arr;        
}



void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "; ");
        }
        System.Console.WriteLine();
    }
}