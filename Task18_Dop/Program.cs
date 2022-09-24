// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
int GetNumber()
{
    Console.WriteLine("Введите номер четверти от 1 до 4: ");
    return Convert.ToInt32(Console.ReadLine());
}
void GetCoordinaty(int numchet)
{
if (numchet == 1)
    Console.WriteLine("Координаты этой четверти: Х>0, Y>0 ");
if (numchet == 2)
    Console.WriteLine("Координаты этой четверти: Х<0, Y>0 ");
if (numchet == 3)
    Console.WriteLine("Координаты этой четверти: Х<0, Y<0 ");
if (numchet == 4)
    Console.WriteLine("Координаты этой четверти: Х>0, Y<0 ");
if (numchet < 1 || numchet > 4)
    Console.WriteLine("Вы ввели не тот диапозон чисел. "); 
}
GetCoordinaty(GetNumber());