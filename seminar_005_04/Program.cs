// Задача 4: Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12*
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void DiapasonFind(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    Console.WriteLine(string.Join(",", array));
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 & array[i] < 100)
        {
            count += 1;
        }    
    }
    Console.WriteLine($"количество элементов в отрезке [10,99] = {count}");
}

int[] array = new int[12];

DiapasonFind(array);
