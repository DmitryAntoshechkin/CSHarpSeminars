// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string Input()
{
    Console.Write("Введите число: ");
    return (Console.ReadLine());
}

int count = 0;
Console.WriteLine("Для остановки подсчета введите stop");
string input = Input();

while (input != "stop" && input != "Stop" && input != "STOP")
{

    if (double.TryParse(input, out double number))
    {

        if (number > 0) count++;
    }
    else Console.WriteLine("Ошибка ввода!");
    input = Input();

}
Console.WriteLine($"Количество положительных чисел: {count}");
