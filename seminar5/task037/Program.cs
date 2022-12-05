// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] array = GetRandomArray(size, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", array));

int[] array2 = new int[(array.Length + 1) / 2];

for (int i = 0; i < array2.Length; i++)
{
    if (i == array2.Length - 1 && array.Length % 2 == 1)
    {
        array2[i] = array[i];
    }
    else
    {
        array2[i] = array[i] * array[array.Length - i - 1];
    }
}
Console.WriteLine(string.Join(", ", array2));