// Задача 60:
// 1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// 2. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    // Random rnd = new Random();
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = count;
                count++;
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],4}");
                Console.Write($"({i},");
                Console.Write($"{j},");
                Console.Write($"{k})");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array3d = CreateMatrixRndInt(2, 2, 2, 0, 9);

if (array3d.GetLength(0) + array3d.GetLength(1) + array3d.GetLength(2) > 13)
{
    Console.WriteLine("Размер матрицы больше допустимого");
}
else
{
    PrintMatrix(array3d);
}