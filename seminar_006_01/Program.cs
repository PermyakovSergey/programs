// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GenArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine(string.Join(", ", arr));
    return arr;
}

void Mirror(int[] array)
{
    int[] mirror = new int[array.Length];

    for (int index = 0; index < array.Length; index++)
    {
        mirror[index] = array[array.Length - index - 1];
    }
    Console.WriteLine(string.Join(", ", mirror));
}

Console.Write("Please enter a size of massive: ");
int size = int.Parse(Console.ReadLine());
int[] array = GenArray(size);
Mirror(array);