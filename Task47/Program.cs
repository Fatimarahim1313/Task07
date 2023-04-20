//// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int[,] CreateArray(int length1, int lenght2)
{
    int[,] Array = new int[length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-10, 10);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i, j] + "\t");

        }
        System.Console.WriteLine();
    }
}

PrintArray(CreateArray(3, 4));