// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа: ");
int pow = Convert.ToInt32(Console.ReadLine());
if (pow < 1)
{
    Console.Write("Введена некорректная степень!");
}
else
{
    double result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result *= number;
    }
    Console.WriteLine($"{number} в степени {pow} равно {result} ");
}