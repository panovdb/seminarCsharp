/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/

int start = 8;
int finish = 2;

PrintNaturalInt(start, finish);

void PrintNaturalInt(int start, int finish)
{
    if (start <= finish)
    {
        System.Console.Write(start + " ");
        PrintNaturalInt(start + 1, finish);
    }
}