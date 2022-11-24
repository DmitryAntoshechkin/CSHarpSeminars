//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Введено некорректное число!");
}
else
{
    if (number == 6 || number == 7) Console.WriteLine("Ура! Выходной!");
    else Console.WriteLine("Пора на работу...");
}
