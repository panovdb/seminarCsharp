/*Павел Гуляев: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
делать через строку -> int в стринг*/


int n = -10;
System.Console.WriteLine(ConvertToBin(n));

string ConvertToBin(int n)
{
    string res = string.Empty;
    while(n != 0)
    {
        res = n % 2 + res;
        n = n / 2;
    }

    return res;
}