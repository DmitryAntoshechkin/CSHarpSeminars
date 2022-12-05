// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
if (size < 2) Console.WriteLine("Размер массива не может быть меньше 2");
else
{
    const int LEFTRANGE = 1;
    const int RIGHTRANGE = 99;

    int[] array = GetRandomArray(size, LEFTRANGE, RIGHTRANGE);
    Console.WriteLine(string.Join(", ", array));
    int max = array[0];
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {max - min}");
}