// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    bool error;
    int number;
    do
    {
        Console.Write(message);
        string input = Console.ReadLine();
        error = int.TryParse(input, out number);
        if (error == false)
        {
            Console.WriteLine("Ошибка ввода!");
        }
        else
        {
            if (number < 1)
            {
                Console.WriteLine("Введите число больше 0!");
            }
        }

    }
    while (error == false || number < 1);
    return number;
}

int GetSum(int num1, int num2)
{

    if (num1 > num2)
    {
        return 0;
    }
    return num1 + GetSum(num1 + 1, num2);
}

int number1 = GetNumber("Введите первое натуральное число: ");
int number2 = GetNumber("Введите второе натуральное число: ");
if (number2 < number1)
{
    int temp = number2;
    number2 = number1;
    number1 = temp;
}
int sum = GetSum(number1, number2);
Console.WriteLine("Сумма чисел: " + sum);



