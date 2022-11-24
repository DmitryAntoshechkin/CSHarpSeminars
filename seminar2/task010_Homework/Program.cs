/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
​
456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели некорректное число!");
}
else
{
    int result = (number % 100) / 10;
    Console.WriteLine("Искомое число: " + result);
}