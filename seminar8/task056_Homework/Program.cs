// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matr;
}

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
            if (number < 1)
            {
                Console.WriteLine("Введите число больше 0!");
            }
        }

    }
    while (error == false || number < 1);
    return number;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int FindMinSumRow(int[,] matr)
{
    int minSum = matr.GetLength(1)*9;
    int minSumRow = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
    }
    return minSumRow;
}



int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
int row = FindMinSumRow(matrix);
Console.WriteLine("Строка с минимальной суммой элементов: " + (row + 1));