// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец, на пересечении которых 
// расположен наименьший элемент.

int[,] GenRandomArray()
{
    int[,] randomarray = new int[4, 4];
    for (int i = 0; i < randomarray.GetLength(0); i++)
    {
        for (int j = 0; j < randomarray.GetLength(1); j++)
        {
            randomarray[i, j] = new Random().Next(0, 100);
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

int[,] DeleteRawColumnMinElement(int[,] arr)
{
    int minElement = arr[0, 0];
    int minIndex = 0;
    int maxIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minElement)
            {
                minElement = arr[i, j];
                minIndex = i;
                maxIndex = j;
            }
        }
    }
    Console.WriteLine($"minElement = {minElement}, minIndex = {minIndex}, maxIndex = {maxIndex}");
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int x = 0;
    int y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == minIndex) continue;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == maxIndex) continue;
            newArr[x, y] = arr[i, j];
            y++;
        }
        x++;
        y = 0;

    }
    return newArr;
}



int[,] array = GenRandomArray();
PrintArray(array);
Console.WriteLine();
int[,] arrayWithoutRawColumn = DeleteRawColumnMinElement(array);
PrintArray(arrayWithoutRawColumn);


