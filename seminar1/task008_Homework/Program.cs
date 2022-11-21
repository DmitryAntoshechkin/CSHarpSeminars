Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2){
    Console.WriteLine("Нет целых четных чисел больше 1 в диапазоне до " + number);
}else{
Console.Write("Четные числа: ");
for (int i = 2; i <= number; i=i+2){
    Console.Write(i + " ");
}
}
