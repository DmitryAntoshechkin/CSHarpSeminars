int number = new Random().Next(10, 100);
Console.WriteLine(number);
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1 > digit2) Console.WriteLine($"Большая цифра {digit1}");
else Console.WriteLine($"Большая цифра {digit1}");

