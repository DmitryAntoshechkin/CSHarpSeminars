// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] MiltiplyMatrix(int[,]matr1, int[,]matr2)
{
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int mult = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                mult = mult + matr1[i,k] * matr2[k,j];
            }
            result[i,j] = mult;
        }
    }
return result;
}

Console.WriteLine("Введите размер первой матрицы");
int rows1 = GetNumber("Введите число строк: ");
int columns1 = GetNumber("Введите число столбцов: ");
int[,] matrix = GetMatrix(rows1, columns1);

Console.WriteLine("Введите размер второй матрицы");
int rows2 = columns1;
Console.WriteLine("Число строк второй матрицы: " + rows2);
int columns2 = GetNumber("Введите число столбцов: ");
int[,] matrix2 = GetMatrix(rows2, columns2);

Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] res = MiltiplyMatrix(matrix, matrix2);
Console.WriteLine();
Console.WriteLine("Перемножение матриц:");
PrintMatrix(res);




