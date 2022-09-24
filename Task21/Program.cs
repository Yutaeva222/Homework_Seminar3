// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int Input()
{
    return Convert.ToInt32(Console.ReadLine());
}
void zadacha21()
{
    Console.Write("Введите координату Х для первой точки: ");
    int x = Input();
    Console.Write("Введите координату Y для первой точки: ");
    int y = Input();
    Console.Write("Введите координату Z для первой точки: ");
    int z = Input();
    Console.Write("Введите координату Х для второй точки: ");
    int x1 = Input();
    Console.Write("Введите координату Y для второй точки: ");
    int y1 = Input();
    Console.Write("Введите координату Z для второй точки: ");
    int z1 = Input();    

    int A = x - x1;
    int B = y - y1;
    int C = z - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
length = Math.Round(length, 2);
Console.WriteLine("Длина отрезка между точками = " + length);
}
zadacha21();