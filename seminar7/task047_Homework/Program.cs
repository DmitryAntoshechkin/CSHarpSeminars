// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​// m = 3, n = 4.
// ​// 0,5 7 -2 -0,2
// ​// 1 -3,3 8 -9,9
// ​// 8 7,8 -7,1 9

double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -9, int rightRange = 9)
{
    double[,] matr = new double[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.NextDouble() * (rightRange - leftRange) + leftRange;
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
        Console.WriteLine(message);
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

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Введите число строк");
int columns = GetNumber("Введите число столбцов");
double[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
