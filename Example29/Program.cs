/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

string textNumbers = String.Empty;

System.Console.WriteLine("Введите цифру для индекса 0");
textNumbers = Console.ReadLine();

for (int i = 1; true; i++)
{
    System.Console.WriteLine($"Введите цифру для индекса {i}, чтобы закончить ввод оставте строчку пустой");
    string number = Console.ReadLine();
    if (number == "") break;
    textNumbers = textNumbers + ", " + number;
}
System.Console.Write(textNumbers);

string[] text = textNumbers.Split(", ");

System.Console.Write(" -> [");

foreach (var item in text)
{
    System.Console.Write(item + ", ");
}

System.Console.WriteLine("]");

