// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}


Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());

const int LEFTRANGE = -99;
const int RIGHTRANGE = 99;

int[] array = GetRandomArray(number, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", array));
for (int i = 0; i < number; i++){
    array[i] = -array[i];
}
Console.WriteLine(string.Join(", ", array));
