// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

bool found = false;
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
 
Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = GetRandomArray(size, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", array));
for (int i = 0; i < size; i++){
    if (array[i] == number){
        found = true;
        break;
    }
}
if (found){
Console.WriteLine("Число найдено");
}else{
    Console.WriteLine("Число не найдено");
}