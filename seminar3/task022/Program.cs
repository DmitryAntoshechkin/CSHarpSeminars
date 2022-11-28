// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.Write("Введите положительное число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("Вы ввели неверное число!");
for (int i = 1 ; i <= number ; i++){
    Console.Write($"{i * i}, ");
}

