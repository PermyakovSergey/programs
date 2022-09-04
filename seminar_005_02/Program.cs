// Задача 2: Задайте массив из 10 элементов и положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(string.Join(",", array));
    return array;
}
int[] Replacement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
int[] array = new int[10];

RandomArray(array);
Replacement(array);
Console.WriteLine(string.Join(",", array));