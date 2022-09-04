// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решение для 5ти чисел:

int[] EnterNumbersOfArray()
{
    int[] arr = new int[5];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter the number {i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine(string.Join(", ", arr));
    return arr;
}

void SummOfPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count ++;
    }
    Console.WriteLine($"Number of positive numbers = {count}");
}

Console.WriteLine("Enter 5 numbers");
int[] array = EnterNumbersOfArray();
SummOfPositiveNumbers(array);