//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем


int[] array = new int[8];
Console.WriteLine("Введите массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив [{string.Join(", ", array)}]");