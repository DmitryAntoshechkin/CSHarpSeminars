// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] GetMatrix(int dim1, int dim2, int dim3, int leftRange = 10, int rightRange = 99)
{
    int[,,] matr = new int[dim1, dim2, dim3];
    int[,] pool = new int[10, 10];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)

                do
                {
                    int tryNumber = rand.Next(leftRange, rightRange + 1);
                    if (pool[tryNumber / 10, tryNumber % 10] != 1)
                    {
                        matr[i, j, k] = tryNumber;
                        pool[tryNumber / 10, tryNumber % 10] = 1;
                    }
                } while (matr[i, j, k] == 0);
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

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {

                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


bool inputError;
int dimension1, dimension2, dimension3;
do
{
    inputError = false;
    dimension1 = GetNumber("Введите первое измерение: ");
    dimension2 = GetNumber("Введите второе измерение: ");
    dimension3 = GetNumber("Введите третье измерение: ");
    if (dimension1 * dimension2 * dimension3 > 90)
    {
        Console.WriteLine("Невозможно заполнить массив такого размера неповторяющимися двузначними числами!");
        inputError = true;
    }
} while (inputError);

int[,,] matrix = GetMatrix(dimension1, dimension2, dimension3);

Console.WriteLine();
PrintMatrix(matrix);
