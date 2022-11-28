// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки в пространстве: ");
Console.Write("Х :");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y :");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Z :");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки в пространстве: ");
Console.Write("Х :");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y :");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Z :");
int zb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстрояние между точками равно: {Math.Sqrt(Math.Pow (xb - xa, 2) + Math.Pow (yb - ya, 2) + Math.Pow (zb - za, 2)):f3}");