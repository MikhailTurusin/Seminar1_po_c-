// Задача 43. Напишите программу, которая,
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1=2, k1=5, b2=4, k2=9 -> (-0,5; -0,5)

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    // double y = b2 + ((k2 * b2 - k2 * b1) / (k2 - k1));
    double[] arr = new double[2];
    double x = ((b1 - b2) / (k2 - k1));
    double y = k2 * x + b2;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < 1) arr[i] = x;
        else arr[i] = y;
        
    }
    return arr;
}
void PrintArray(double[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] array = IntersectionPoint(b1, k1, b2, k2);
PrintArray(array);