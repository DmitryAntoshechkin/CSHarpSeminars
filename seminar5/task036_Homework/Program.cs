// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    const int LEFTRANGE = -99;
    const int RIGHTRANGE = 99;
    int sum = 0;

    int[] array = GetRandomArray(size, LEFTRANGE, RIGHTRANGE);
    Console.WriteLine(string.Join(", ", array));

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}