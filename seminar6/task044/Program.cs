// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int [] fib = new int [number];
fib[0] = 0;
fib[1] = 1;

for (int i = 2; i < number; i++){
fib[i] = fib[i-1] + fib[i-2];
}
Console.WriteLine(string.Join(", ", fib));


