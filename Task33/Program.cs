// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool CheckDigit (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num==arr[i]) return true;
    }
    return false;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите от какого числа заполняем массив: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите до какого числа заполняем массив: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которое ищем в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(size, min, max);
PrintArray(array);

bool existNumber=CheckDigit(array, number);
Console.WriteLine(existNumber ? "Да" : "Нет");