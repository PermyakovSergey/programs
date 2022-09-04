// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] GenArray(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
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

void SqrtArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0) { arr[i, j] = arr[i, j] * arr[i, j]; }
        }
    }
}

Console.WriteLine("Please enter number of rows in massive: ");
int r = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter number of columns in massive: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter minimum value of massive: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter maximum value of massive: ");
int max = int.Parse(Console.ReadLine());

int[,] array = GenArray(r, c, min, max);
PrintArray(array);
Console.WriteLine();
SqrtArray(array);
PrintArray(array);