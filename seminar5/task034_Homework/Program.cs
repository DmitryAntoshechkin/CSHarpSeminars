// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 1) Console.WriteLine("Размер массива не может быть меньше 1");
else
{
    const int LEFTRANGE = 100;
    const int RIGHTRANGE = 999;
    int count = 0;

    int[] array = GetRandomArray(size, LEFTRANGE, RIGHTRANGE);
    Console.WriteLine(string.Join(", ", array));

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел: {count}");
}

