// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
//  отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(string.Join(",", array));
    return array;
}
void SummPosNegElements(int[] array)
{
    int minSumm = 0;
    int maxSumm = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            maxSumm += 1;
        }
        if (array[i] < 0)
        {
            minSumm += 1;
        }
    }
    Console.WriteLine($"Сумма положительных элементов равна: {maxSumm} ");
    Console.WriteLine($"Сумма отрицательных элементов равна: {minSumm} ");
}
int[] array = new int[10];

RandomArray(array);
SummPosNegElements(array);
