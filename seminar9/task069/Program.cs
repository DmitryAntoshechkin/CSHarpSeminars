// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int Numbers(int a, int b)
{
    if( b < 1  )
    {
        return 1;
    }
    b--;
    a *= Numbers(a, b);
    return a;
}
int res = Numbers(a, b);
Console.WriteLine(res);