// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
// [1, -5, 8, 4, -9] -> 4.33
void GenArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    Console.WriteLine(string.Join(", ", array));
}

void SummPoz(int[] array)
{
    double result = 0;
    double count = 0;

    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0)
        {
        Console.Write(array[index] + " ");
        count ++;
        result = result + array[index];
        }
    }
    result = result/count;
    Console.WriteLine();
    Console.Write("среднее арифметическое положительных элементов = ");
    Console.WriteLine(result);
}

Console.Write("Please enter a size of massive: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
GenArray(array);
SummPoz(array);