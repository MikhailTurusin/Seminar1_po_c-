// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


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


int[] IndexOfMinElem(int[,] matrix)
{
    int rows = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rows, column])
            {
                rows = i;
                column = j;
            }
        }
    }
    return new int[] { rows, column };
}

int[,] DeleteRowColumn(int[,] matrix, int[] arr)
{
    int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        if (m == arr[0]) m++;
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            if (n == arr[1]) n++;
            newmatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newmatrix;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] indexOfMinElem = IndexOfMinElem(array2d);
int[,] result = DeleteRowColumn(array2d, indexOfMinElem);
PrintMatrix(result);