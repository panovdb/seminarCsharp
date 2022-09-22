/*
Павел Гуляев: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/
int sum = 0;
System.Console.WriteLine(SumOfDigits(23422));

int SumOfDigits(int n) 
{
    if(n > 0) return SumOfDigits(n / 10) + n % 10;
    else return 0;
}