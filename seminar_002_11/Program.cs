//Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//456 -> 46

//782 -> 72

//918 -> 98

Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());

string str = a.ToString();
// int[] b = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    // b[i] = int.Parse(str[i].ToString());

    if (i != 1)
    {
        Console.Write(str[i]);
    }
}
