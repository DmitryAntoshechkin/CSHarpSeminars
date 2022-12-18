// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 99)
{
    int[,] matr = new int[rowsCount, columnsCount];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(leftRange, rightRange);
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
    }
    while (error == false);
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

int rows = GetNumber("Введите число строк");
int columns = GetNumber("Введите число столбцов");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
int[,] invertedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        invertedMatrix[j, i] = matrix[i, j];
    }
}

Console.WriteLine();
PrintMatrix(invertedMatrix);