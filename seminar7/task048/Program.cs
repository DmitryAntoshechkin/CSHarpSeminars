// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=99)
{
    int[,] matr = new int[rowsCount, columnsCount];
   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i+j;
        }
    }

    return matr;
}

int GetNumber(string message)
{
    bool error;
    int number;
    do {
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
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
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

