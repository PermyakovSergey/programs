int[,] GenRandomArray()
{
    int[,] randomarray = new int[3, 4];
    for (int i = 0; i < randomarray.GetLength(0); i++)
    {
        for (int j = 0; j < randomarray.GetLength(1); j++)
        {
            randomarray[i, j] = new Random().Next(0, 11);
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
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

double ArithmeticMeanOfColumn(int[,] arr, int indexOfColumn) // метод возвращает ср. арифм-е указанного столбца
{
    double sumOfElements = 0; // в переменную будем складывать значения в текущем столбце
    int countOfElements = arr.GetLength(0); // переменной присваиваем значение количества строк массива, т.к. оно равно
    // количеству чисел в столбце.
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ( j == indexOfColumn)
            {
                sumOfElements += arr[i, j];
            }
        }
    }
    double result = sumOfElements/countOfElements; // вычисление ср. арифметического
    return result;
}

Console.WriteLine("An array of numbers is given");
int[,] array = GenRandomArray();
PrintArray(array);
// инициализируем массив, размером числа столбцов двумерного массива, в значения которого записываются
// результаты вызова метода вычисления среднего арифметического столбцов, соответствующих индексу массива:
// в значение arrayForResult[0], запишется округленный результат для столбца c индексом [i, 0]...
double[] arrayForResult = new double[array.GetLength(1)];
for (int i = 0; i < array.GetLength(1); i++) arrayForResult[i] = Math.Round(ArithmeticMeanOfColumn(array, i), 1);

// Console.WriteLine($"Arithmetic mean of each column: {string.Join("; ", arrayForResult)}");
foreach (double item in arrayForResult) Console.Write($"{item}; ");