// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] CreateArray(int length1, int lenght2)
{
    int[,] Array = new int[length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-100, 100);
        }
    }
    return Array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Позиции массивов начинается с 0");
var array = CreateArray(3, 4);
Console.Write("Введите позицию m:");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите позицию n:");
int n = int.Parse(Console.ReadLine());

PrintArray(array);

if (n < array.GetLength(1) && m < array.GetLength(0))
{
    Console.WriteLine($"Знчение в позиции m = {m} n = {n} -> {array[m, n]}");
}
else
{
    System.Console.WriteLine(" -> такого элемента в массиве нет");
}
