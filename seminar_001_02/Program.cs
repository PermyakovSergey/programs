
Console.WriteLine("Введите первое число");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB*numberB)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}

