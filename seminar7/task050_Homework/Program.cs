// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
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
        Console.Write(message);
        string input = Console.ReadLine();
        error = int.TryParse(input, out number);
        if (error == false)
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
    while (error == false);
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

int row = GetNumber("Введите индекс строки: ");
int column = GetNumber("Введите индекс столбца: ");
int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);
double[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
if (row >= matrix.GetLength(0) || column >= matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента в массиве нет!");
}
else
{
    Console.WriteLine($"Искомое значение: {matrix[row, column]:f2}");
}
