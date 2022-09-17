// Проверка на число
int CheckInputIfNotNumber()
{
    Console.Write("enter a number: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int number))
    {
        Console.Write("Value can't be text, ");
        return CheckInputIfNotNumber();
    }
    return number;
}
// Проверка на генерацию размера массива
int CheckInputForArraySize()
{
    Console.Write("it must be number > 0: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int number))
    {
        Console.Write("Value can't be text, ");
        return CheckInputForArraySize();
    }
    if (number == 0 || number < 0)
    {
        Console.Write("Value can't be negative or zero, ");
        return CheckInputForArraySize();
    }
    return number;
}
// Генерация одномерного массива
int[] GenArray()
{
    Console.WriteLine("Please enter a size of massive: ");
    int size = CheckInputForArr();
    Console.WriteLine("Please enter minimum value of massive: ");
    int min = CheckInputForNumber();
    Console.WriteLine("Please enter maximum value of massive: ");
    int max = CheckInputForNumber());
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine(string.Join(", ", arr));
    return arr;
}
int[] array = GenArray();

// Разворот одномерного массива:

void ReverseArray(int[] array)
{
    int[] reverseArr = new int[array.Length];

    for (int index = 0; index < array.Length; index++)
    {
        reverseArr[index] = array[array.Length - index - 1];
    }
    Console.WriteLine(string.Join(",", reverseArr));
}

// функция GetNumber от Кости
int GetNumber()
{
    Console.WriteLine("Введите число");
    string text = Console.ReadLine();

    if (!int.TryParse(text, out int number))
    {
        Console.WriteLine("Введите именно число");
        // вызываем внутри функции GetNumber функции GetNumber
        return GetNumber(); // *
    }

    return number;
}
int number = GetNumber();
Console.WriteLine($"Получилось число: {number}");

// Генерация двумерного массива с параметрами заданными пользователем.
double[,] GenRandomArray()
{
    Console.Write("Enter the number of rows in the array, ");
    int rows = CheckInputForArraySize();
    Console.Write("Enter the number of columns in the array, ");
    int columns = CheckInputForArraySize();
    Console.Write("Enter the minimum value of elements in array: ");
    int min = CheckInputIfNotNumber();
    Console.Write("Enter the maximum value of elements in array: ");
    int max = CheckInputIfNotNumber();
    double[,] randomarray = new double[rows, columns];
    if (min > max) { int temp = min; min = max; max = temp; }
    if (min == max)
    { Console.WriteLine("Since the entered minimum and maximum values are equal, the maximum is increased by one"); }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomarray[i, j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);
        }
    }
    return randomarray;
}
double[,] array = GenRandomArray();

// Печать двумерного массива

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

// Поиск числа в двумерном массиве с выводом индекса первого найденного числа

void FindNumberInArray(int[,] arr)
{
    Console.Write("For searching in the array ");
    int numberfind = CheckInputForNumber();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == numberfind)
            {
                Console.WriteLine($"The number {numberfind} was found in the position with the index [{i}, {j}] ");
                return;
            }
        }
    }
    Console.WriteLine($"The number {numberfind} is not in the array");
}

// Поиск числа в двумерном массиве с выводом всех индексов искомого числа
void FindNumberInArray2(int[,] arr)
{
    Console.Write("For searching in the array ");
    int numberfind = CheckInputForNumber();
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == numberfind)
            {
                Console.WriteLine($"The number {numberfind} was found in the position with the index [{i}, {j}] ");
                count++;
            }
        }
    }
    if (count == 0) {Console.WriteLine($"The number {numberfind} is not in the array");}
}

