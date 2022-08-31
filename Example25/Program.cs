/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
int a = 2;
int b = 4;

System.Console.WriteLine($"{a}, {b} -> {pow(a, b)}");

int pow(int a, int b){
    int result = a;

    for (int i = 1; i < b; i++)
    {
        result *= a;
    }

    return result;
}