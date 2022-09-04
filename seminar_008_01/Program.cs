// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2
int[,] GenRandomArray()
{
    int[,] randomarray = new int[3, 4];
    for (int i = 0; i < randomarray.GetLength(0); i++)
    {
        for (int j = 0; j < randomarray.GetLength(1); j++)
        {
            randomarray[i, j] = new Random().Next(0, 11);
        }
    }
    return randomarray;
}

void PrintArray(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReverseRowsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                int temp = array[i, j];
                array[i, j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = temp;
            }
        }
    }
}

int[,] array = GenRandomArray();
PrintArray(array);
Console.WriteLine();
ReverseRowsArray(array);
PrintArray(array);