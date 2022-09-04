// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2

Console.WriteLine("Введите координаты двух точек для нахождения расстояния между ними в 2Д пространстве: ");
double distance(double ax, double ay, double bx, double by)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
}
Console.Write("введите координату X первой точки: "); double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Y первой точки: "); double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату X второй точки: "); double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Y второй точки: "); double by = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + distance(ax, ay, bx, by));
