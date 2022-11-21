Console.Write("Введите  число  от 1 до 7: ");
int data = Convert.ToInt32(Console.ReadLine());
if ( data == 1) {
    Console.WriteLine("Понедельник");
}
else if (data == 2) {
    Console.WriteLine("Вторник");
}
else if (data == 3) {
    Console.WriteLine("Среда");
}
else if (data == 4) {
    Console.WriteLine("Четверг");
}
else if (data == 5) {
    Console.WriteLine("Пятница");
}
else if (data == 6) {
    Console.WriteLine("Суббота");
}
else if (data == 7) {
    Console.WriteLine("Воскресенье");
}
else {
    Console.WriteLine("Введено не корректное число");
}


