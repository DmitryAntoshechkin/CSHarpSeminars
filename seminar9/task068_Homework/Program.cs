// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9


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
            if (number < 0)
            {
                Console.WriteLine("Введите неотрицательное число");
            }
        }

    }
    while (error == false || number < 0);
    return number;
}

int GetAkkerman(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return GetAkkerman(m - 1, 1);
    }

    return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}

int number1 = GetNumber("Введите первое натуральное число: ");
int number2 = GetNumber("Введите второе натуральное число: ");
int result = GetAkkerman(number1, number2);
Console.WriteLine("Результат функции Аккермана: " + result);