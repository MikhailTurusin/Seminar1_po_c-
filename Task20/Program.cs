// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance(int x1, int y1, int x2, int y2)
{
    double square1 = Math.Pow(x2 - x1, 2);
    double square2 = Math.Pow(y2 - y1, 2);
    double root = Math.Sqrt(square1 + square2);
    return root;
}

Console.WriteLine("Введите координаты точки A");
int ax1 = Convert.ToInt32(Console.ReadLine());
int ay1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
int bx2 = Convert.ToInt32(Console.ReadLine());
int by2 = Convert.ToInt32(Console.ReadLine());

// // double number = Math.Pow(bx2 - ax1, 2);
// // double number1 = Math.Pow(by2 - ay1, 2);
// // double number2 = Math.Sqrt(number + number1);
// double result = Math.Round(number2, 2, MidpointRounding.ToZero);

double res = Distance(ax1, ay1, bx2,by2);
double result = Math.Round(res, 2, MidpointRounding.ToZero);
Console.Write(result);