// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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
        Console.WriteLine("Это число палиндром! ");
    }
    else 
    {
        Console.WriteLine("Это число НЕ палиндром! ");
    }
}
zadacha();
