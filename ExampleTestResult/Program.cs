/*
Итоговая проверочная работа.
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. 
Мы должны убедиться что базовое знакомство с it прошло успешно.
Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1.	Создать репозиторий на GitHub
2.	Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3.	Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4.	Написать программу, решающую поставленную задачу
5.	Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, 
как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", "Yes"]-> ["2"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/


string[] array1 = { "hello", "2", "world", "Yes"};
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };
const int maxSimbols = 3;

PrintArray(array1);
System.Console.Write(" -> ");
PrintArray(SelectArray(array1, maxSimbols));

string[] SelectArray(string[] array, int maxSimbols)
{
    string[] arraySelect = new string[CountInnerStringInArray(array, maxSimbols)];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxSimbols)
        {
            arraySelect[j] = array[i];
            j++;
        }

    }
     return arraySelect;
}

int CountInnerStringInArray(string[] array, int maxSimbols)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxSimbols) count++;
    }
    return count;
}

void PrintArray(string[] array)
{
    if(array.Length == 0) 
    {
        System.Console.Write("[]");
        return;
    }
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