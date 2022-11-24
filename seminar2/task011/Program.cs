int number = new Random().Next(100, 1000);
Console.WriteLine("Трехзначное число: " + number);
int result = (number % 10)+(number / 100)*10;
Console.WriteLine("Искомое число: " + result);

