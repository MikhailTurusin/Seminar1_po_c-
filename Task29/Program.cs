// Задача 29: Напишите программу, которая
// 1. задаёт массив из 8 элементов,
// 2. заполненный псевдослучайными числами и
// 3. выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number != 8) Console.WriteLine ("Нужно ввести массив из 8 элементов, повторите попытку");
else
{
Console.WriteLine("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = Array(number, min, max);
PrintArray(array);
}

int[] Array(int num, int min, int max)
{
    Random rand = new Random();
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");  
    }
    Console.Write("-> ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i<array.Length-1) Console.Write(", ");
    }
    Console.Write("]");
}