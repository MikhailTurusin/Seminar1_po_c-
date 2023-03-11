// Задача 56:
// 1. Задайте прямоугольный двумерный массив.
// 2. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[] CreateArraySumRowsElem(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int m = 0; m < arr.Length;)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
            arr[m] = sum;
            sum = 0;
            m++;
        }
    }
    return arr;
}

int SearchRowMinElemSum (int[]arr)
{
    int min=arr[0];
    int minIndex=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min=arr[i];
            minIndex=i;
        }
    }
    return minIndex;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = CreateArraySumRowsElem(array2d);
PrintArray(array);

int result=SearchRowMinElemSum(array);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {result}");