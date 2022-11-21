Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB) {
    Console.WriteLine ("Числа равны");
}else if (numberA > numberB) {
        Console.WriteLine ("Первое число больше");
}
else {
        Console.WriteLine ("Второе число больше");
}
