// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{ Console.Write("Введено неверное число! "); }
else
{
    double mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult *= i;
    }
Console.WriteLine($"Факториал числа {number}: {mult} ");
}