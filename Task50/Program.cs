// Задача 50: Напишите программу, которая,
// 1. на вход принимает позиции элемента в двумерном массиве,
// 2. и возвращает значение этого элемента
// 3. или же указание, что такого элемента нет.

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

bool ElementSearch(int[,] matrix, int rowNum, int columnsNum)
{
    return rowNum < matrix.GetLength(0) && columnsNum < matrix.GetLength(1);
}

int[,] array2d = CreateMatrixRndInt(4, 4, -1, 9);
PrintMatrix(array2d);

Console.Write("Введите номер строки, где находится элемент двумерного массива: ");
int rowNumber = Convert.ToInt32((Console.ReadLine()));
Console.Write("Введите номер столбца, где находится элемент двумерного массива: ");
int columnsNumber = Convert.ToInt32((Console.ReadLine()));
if(rowNumber<0 || columnsNumber<0) Console.WriteLine("Значение не должно быть отрицательным");
else
{
    bool result = ElementSearch(array2d, rowNumber, columnsNumber);
    Console.WriteLine(result ? $"Значение элемента: {array2d[rowNumber, columnsNumber]}" : $"{rowNumber}, {columnsNumber} -> Такого элемента нет");
}