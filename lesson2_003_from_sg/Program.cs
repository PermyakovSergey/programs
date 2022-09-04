Console.Write("Для определения диапазона четных чисел от нуля и до этого числа, введите число неравное 0: ");
float number = float.Parse(Console.ReadLine());
float evenNumber = 0;
if(number < 0)
{
    Console.Write("Диапозон отрицательных четных чисел: ");
    while(number < evenNumber )
    {
        if(evenNumber % 2 == 0) Console.Write(evenNumber +", ");
        evenNumber--;
    }
}
if (number > 0)
{
    Console.Write("Диапозон положительных четных чисел: ");
    while(number > evenNumber )
    {
        if(evenNumber % 2 == 0) Console.Write(evenNumber +", ");
        evenNumber++;
    }
}