/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
int[] array = CreateIntArrayFromConsole();
int count = CountPositiveNumbers(array);
PrintArray(array);
System.Console.WriteLine(" -> " + count);



int[] CreateIntArrayFromConsole()
{   
    System.Console.WriteLine("Введите количество чисел которые нужно ввести в программу");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите цифру для индекса {i}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int CountPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result++;
    }
    return result;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    foreach (var item in array)
    {
        System.Console.Write(item + ", ");
    }
    int origRow = Console.CursorTop;
    int origCol = Console.CursorLeft;
    Console.SetCursorPosition(origCol - 2, origRow);
    System.Console.Write("]");
}