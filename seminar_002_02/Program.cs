// Напишите программу, которая генерирует случайное трехзначное число и удаляет вторую цифру этого числа

Console.WriteLine("будет сгенерировано случайное трехзначное число, и будет удалена вторая цифра этого числа");

int number = new Random().Next(100, 1000);
string str = number.ToString();
Console.WriteLine(number);
for (int i = 0; i < str.Length; i++)
{
    if (i != 1)
    {
        Console.Write(str[i]);
    }
}
