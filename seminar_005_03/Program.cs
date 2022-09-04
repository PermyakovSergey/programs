// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void ArrayFind(int number)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 5);
    }
    Console.WriteLine(string.Join(",", array));
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"Искомое число: {array[i]} найдено под индексом {i}");
            return;
        }
    }
    Console.WriteLine($"Искомое число: {number} отсутствует в данном массиве");
}

void Check()
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        ArrayFind(number);
    }
    else Console.WriteLine("wrong number");
}

Console.Write("Введите для поиска его в случайном массиве: ");
Check();
