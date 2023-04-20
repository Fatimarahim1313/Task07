// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

var array = CreateArray(4, 5);

PrintArray(array);

Console.WriteLine($"Среднее арифметическое каждого столбца:");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    double avarage = sum / array.GetLength(0);
    Console.Write($"{avarage}\t");
}

int[,] CreateArray(int length1, int lenght2)
{
    int[,] array = new int[length1, lenght2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
    return array;
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
