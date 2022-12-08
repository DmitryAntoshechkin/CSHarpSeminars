void Check(int n)
{
    int numberOne = 0;
    int numberTwo = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(numberOne + " ");
        int x = numberOne + numberTwo;
        numberOne = numberTwo;
        numberTwo = x;
    }
}
Console.WriteLine("Введите колличество символов");
int n = int.Parse(Console.ReadLine()!);
Check(n);
