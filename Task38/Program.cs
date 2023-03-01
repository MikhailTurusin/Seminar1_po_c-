// Задача 38:
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=Math.Round(arr[i], 1, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{(arr[i])}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MaxElementSearch (double[] arr)
{
    double maxElem=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]>maxElem) maxElem=arr[i];
    }
    return maxElem;
}

double MinElementSearch (double[] arr)
{
    double minElem=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<minElem) minElem=arr[i];
    }
    return minElem;
}

double[] array = CreateArrayRndDouble(5, 1, 10);
double maxElement=MaxElementSearch(array);
double minElement=MinElementSearch(array);
double result=maxElement-minElement;
double result1=Math.Round(result, 1, MidpointRounding.ToZero);

PrintArray(array);
Console.Write($" -> {result1}");