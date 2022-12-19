Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
//int res = 2;
void Numbers(int number)
{

    if( number == 0  )
    {
        return;
    }
    Numbers( number - 1);
    Console.Write(number + "  ");
}
Numbers(n);

