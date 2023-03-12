// Задача 62: Заполните спирально массив 4 на 4.

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;

    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = count;
            count++;
        }
        for (int j = 3; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(0); k++)
            {
                matrix[k, j] = count;
                count++;
            }
        }
        for (int k = 3; k < matrix.GetLength(0); k++)
        {
            for (int j = 2; j > i - 1; j--)
            {
                matrix[k, j] = count;
                count++;
            }
        }
        for (int j = 0; j < 1; j++)
        {
            for (int k = 2; k > j; k--)
            {
                matrix[k, j] = count;
                count++;
            }
        }
        for (int k = 1; k < 2; k++)
        {
            for (int j = 1; j < 3; j++)
            {
                matrix[k, j] = count;
                count++;
            }
        }
        for (int k = 2; k < 3; k++)
        {
            for (int j = 2; j > k-2; j--)
            {
                matrix[k, j] = count;
                count++;
            }
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

int[,] array2d = CreateMatrixRndInt(4, 4);
PrintMatrix(array2d);