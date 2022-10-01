/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 
Некорректный пример m и n перепутанны

*/
int m = 3;
int n = 2;
System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)  return n + 1;
    else if ((m > 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else if ((m > 0) && (n > 0))
        return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return n + 1;
}
