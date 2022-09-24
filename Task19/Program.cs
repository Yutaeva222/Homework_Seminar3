Console.Clear();
int Input()
{
    Console.WriteLine("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void zadacha()
{
    int num = Input();
    int one = num / 10000 % 10;
    int two = num / 1000 % 10;
    int three = num / 100 % 10;
    int four = num / 10 % 10;
    int five = num % 10;
    if (one == five && two == four)
    {
        Console.WriteLine("Это число полиндром! ");
    }
    else 
    {
        Console.WriteLine("Это число НЕ полиндром! ");
    }
}
zadacha();
