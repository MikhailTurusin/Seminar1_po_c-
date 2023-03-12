// Задача 58:
// 1. Задайте две матрицы.
// 2. Напишите программу, которая будет находить произведение двух матриц.

int[,] MultiplicationTwoMatrix(int[,] matrix, int[,] matrix1)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                newMatrix[i, j] += matrix[i, k] * matrix1[k, j];
            }
        }
    }
    return newMatrix;
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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}


int[,] array2d = CreateMatrixRndInt(4, 4, -1, 9);
int[,] newarray2d = CreateMatrixRndInt(4, 4, -1, 9);
PrintMatrix(array2d);
Console.WriteLine();
PrintMatrix(newarray2d);
Console.WriteLine();
if (array2d.GetLength(1)!=newarray2d.GetLength(0))
Console.WriteLine("Число столбцов 1ой матрицы должно быть равно числу строк 2ой матрицы");
else
{
int[,] newarra2d = MultiplicationTwoMatrix(array2d, newarray2d);
PrintMatrix(newarra2d);
}