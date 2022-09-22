/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = 4;
int n = 8;

System.Console.WriteLine(SumNums(m, n));

int SumNums(int m, int n)
{
    if(m < n) return SumNums(m + 1, n) + m;
    return n;
}