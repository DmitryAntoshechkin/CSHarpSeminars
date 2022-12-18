// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] GetMatrix(int rowsCount, int columnsCount)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();
    int currentRow = 0;
    int currentColumn = 0;
    int offsetRow = 0;
    int offsetColumn = 1;
    int number = 1;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        currentColumn = i;
        matr[currentRow, currentColumn] = number;
        number++;
    }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        currentRow = i;
        matr[currentRow, currentColumn] = number;
        number++;

    }
    for (int i = matr.GetLength(1) - 2; i >= 0; i--)
    {
        currentColumn = i;
        matr[currentRow, currentColumn] = number;
        number++;

    }
    for (int i = matr.GetLength(0) - 2; i >= 1; i--)
    {
        currentRow = i;
        matr[currentRow, currentColumn] = number;
        number++;
    }
    while (number <= rowsCount * columnsCount)
    {
        if (matr[currentRow + offsetRow, currentColumn + offsetColumn] != 0)
        {
            if (matr[currentRow, currentColumn + 1] == 0)
            {
                offsetRow = 0;
                offsetColumn = 1;
            }
            else if (matr[currentRow + 1, currentColumn] == 0)
            {
                offsetRow = 1;
                offsetColumn = 0;
            }
            else if (matr[currentRow, currentColumn - 1] == 0)
            {
                offsetRow = 0;
                offsetColumn = -1;
            }
            else if (matr[currentRow - 1, currentColumn] == 0)
            {
                offsetRow = -1;
                offsetColumn = 0;
            }
        }
        currentRow += offsetRow;
        currentColumn += offsetColumn;
        matr[currentRow, currentColumn] = number;
        number++;
    };

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
            if (number < 2)
            {
                Console.WriteLine("Введите число больше 1!");
            }
        }

    }
    while (error == false || number < 2);
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

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
Console.WriteLine();
PrintMatrix(matrix);
