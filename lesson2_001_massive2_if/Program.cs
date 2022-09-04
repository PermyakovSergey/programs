void FillArray(int[] colection)//метод FillArray заполняет массив случайными элементами
{
    int length = colection.Length;
    int index = 0;
    while (index < length)
    {
        colection[index] = new Random().Next(1, 10);
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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int pos = -1;//выводит "-1", если в сгенерированом массиве чисел не окажется искомого.
    while (index < count)
    {
        if (collection[index] == find)
        {
            pos = index;
            break;//если искомых чисел окажется несколько, выводить только индек первого найденного.

        }
        index++;
    }
    return pos;
}

int[] array = new int[10];// Определили массив из 10 элементов,

FillArray(array);// затем вызвали FillArray,
PrintArray(array);//  затем PrintArray

Console.WriteLine();

int pos = IndexOf(array, 4);// 4 - задаем искомое число
Console.WriteLine(pos);