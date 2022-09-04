Console.WriteLine("Enter two numbers, and i say is second number multiple to the first number");
Console.Write("Enter the first number ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number ");
double b = Convert.ToInt32(Console.ReadLine());

if (b == 0)
{
    Console.WriteLine("Invalid");
}
if (a % b == 0)
{
    Console.WriteLine("yes");
}
if (a % b > 0)
{
    Console.Write("No, the remainder of the division is: ");
    Console.WriteLine(a % b);
}