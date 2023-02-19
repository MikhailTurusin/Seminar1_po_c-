// Задача 21. Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double square1 = Math.Pow(x2 - x1, 2);
    double square2 = Math.Pow(y2 - y1, 2);
    double square3 = Math.Pow(z2 - z1, 2);
    double root = Math.Sqrt(square1 + square2 + square3);
    return root;
}

Console.WriteLine("Введите координаты точки A");
int ax1 = Convert.ToInt32(Console.ReadLine());
int ay1 = Convert.ToInt32(Console.ReadLine());
int az1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
int bx2 = Convert.ToInt32(Console.ReadLine());
int by2 = Convert.ToInt32(Console.ReadLine());
int bz2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(ax1, ay1, az1, bx2, by2, bz2);
double result = Math.Round(res, 2, MidpointRounding.ToZero);
Console.Write(result);