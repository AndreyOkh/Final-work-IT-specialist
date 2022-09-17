// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите данные разделяя их пробелом: ");
string input = Console.ReadLine()!;

string[] values = input.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

string[] filteredValues = new string[0];

foreach (string value in values)
{
    if (value.Length < 4)
        filteredValues = FillArray(filteredValues, value);
}

PrintArray(values, "Изначальный массив");
PrintArray(filteredValues, "Отфильтрованный массив");

void PrintArray(string[] array, string message)
{
    Console.Write($"{message} {String.Join(", ", array)}");
    Console.WriteLine();
}

string[] FillArray(string[] array, string value)
{
    int arraySize = array.Length;
    Array.Resize(ref array, arraySize + 1);
    array[arraySize] = value;
    return array;
}