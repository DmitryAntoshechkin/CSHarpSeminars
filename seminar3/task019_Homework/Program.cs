// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10 && number > -10) Console.WriteLine("Для проверки на полиндом в числе должно быть 2 знака или более!");
else
{
    if (number < 0) number = -number;
    int count = number;
    int invertedNumber = 0;
    while (count > 0)
    {

        invertedNumber = invertedNumber * 10 + count % 10;
        count /= 10;

    }
    if (number == invertedNumber) Console.WriteLine("Число палиндром");
    else Console.WriteLine("Число не палиндром");
}