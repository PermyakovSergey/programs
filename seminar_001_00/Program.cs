// Если введено положительное число, то возводим его в квадрат

Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    number *= number;
    Console.Write("Число возведенное в квадрат ");
    Console.WriteLine("Число возведенное в квадрат: " + number);
}
if (number < 0)
{
    Console.WriteLine("Число отрицательное");
}
if (number == 0)
{
    Console.WriteLine("Введен ноль");
}

