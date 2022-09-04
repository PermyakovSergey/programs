void FillArray(int[] colection)//метод FillArray заполняет массив случайными элементами
{
    int length = colection.Length;
    int index = 0;
    while (index < length)
    {
        colection[index] = new Random().Next(1, 1000);
        index++;
    }
}
void PrintArray(int[] col)// метод PrintArray выводит список сгенерированных значений массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];// Определили массив из 10 элементов,

FillArray(array);// затем вызвали FillArray,
PrintArray(array);//  затем PrintArray

Console.WriteLine();
int position = 0;
int max = array[position];

while (position < array.Length)
{
    if (array[position] > max)
    {
        max = array[position];
    }
    position++;
}
Console.WriteLine(max);