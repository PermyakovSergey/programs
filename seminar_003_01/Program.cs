// Задачи на 3 семинар:
// Задача 1.
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер четверти плоскости, в которой находится эта точка
//  и показывает диапазон возможных координат точек в этой четверти (x и y).

// A (2, 3) -> 1 четверть, x > 0, y > 0
// A (-5, -8) -> 3 четверть, x < 0, y < 0

// Формулы вычисления расстояния между двумя точками:

void coordinatePlane(double x, double y)
{
    if (x > 0 & y > 0) Console.WriteLine("Coordinate Plane is First");
    if (x < 0 & y > 0) Console.WriteLine("Coordinate Plane is Second");
    if (x < 0 & y < 0) Console.WriteLine("Coordinate Plane is Third");
    if (x > 0 & y < 0) Console.WriteLine("Coordinate Plane is Fourth");
    else Console.WriteLine("Coordinates are not set currectly");
}
Console.WriteLine("Введите координаты X и Y точки, для определения четверти плоскости координат в которой она находится");
Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());
coordinatePlane(x, y);
