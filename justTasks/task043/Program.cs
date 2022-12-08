//43. Написать программу преобразования десятичного числа в двоичное

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int depth = 1;
while (Math.Pow(2,depth) <= number) depth++;
int[] binary = new int[depth];
int i = number;
while (i > 0){
    binary[depth-1] = i % 2;
    i /= 2;
    depth --;
}
int count = binary.Length;
for (int j = 0; j < count; j++)
{
Console.Write ($"{binary[j]} ");
}
Console.WriteLine();
