void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i] }");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            maxPosition = j;
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
int[] arr = { 1, 9, 3, 1, 1, 6, 4, 5, 8, 2, 7, 9 };
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);