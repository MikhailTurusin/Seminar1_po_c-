// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите от какого числа заполняем массив: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите до какого числа заполняем массив: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = Array(number, min, max);
PrintArray(array);

int[] Array(int num, int min, int max)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}