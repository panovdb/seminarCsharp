/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
System.Console.WriteLine("Введите значение b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] point = new double[2];

if ((k1 == k2) & (b1 == b2)) System.Console.WriteLine("Прямые идентичны");
else if (k1 == k2) System.Console.WriteLine("Прямые параллельны");
else point = CrossLine(b1, k1, b2, k2);

//System.Console.WriteLine(point[0] + ", " + point[1]);
System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({point[0]}; {point[1]})");

double[] CrossLine(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    double[] point =  {x , y};
    return point;
}