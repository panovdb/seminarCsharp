/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

string result = string.Empty;
PrintNaturalInt(100);

void PrintNaturalInt(int n)
{
    if(n > 1) PrintNaturalInt(n - 1);
    System.Console.Write(n + " ");

    /*System.Console.Write(n + " ");
    if(n > 1) PrintNaturalInt(n - 1);*/
    
}