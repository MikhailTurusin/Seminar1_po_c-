// Задача 57:
// 1. Составить частотный словарь элементов двумерного массива.
// 2. Частотный словарь содержитинформацию о том, сколько раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[count] = matrix[i, j];
            count++;
        }
    }
    return arr;
}

void FrequencyDictionaryArray(int[] arr)
{
    int count=1;
    int num=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i]==num)
        count++;
        else
        {
            Console.WriteLine($"Число {num} встречается {count} раз.");
            num=arr[i];
            count=1;
        }
    }
    Console.Write($"Число {num} встречается {count} раз.");    
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 25);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = MatrixToArray(array2d);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
FrequencyDictionaryArray(array);