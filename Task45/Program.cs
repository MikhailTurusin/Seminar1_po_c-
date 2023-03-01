// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int [] CopyArray(int size, int[]arr)
{
    int[] arr1= new int[size];
    // arr1[0]=99;
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i]=arr[i];
    }
    return arr1;
}

Console.Write("Введите размер массивов: ");
int size=Convert.ToInt32(Console.ReadLine());

int[] array=CreateArrayRndInt(size, 0, 10);
PrintArray(array);

int[] array1=CopyArray(size, array);
// array1[0]=99;
PrintArray(array1);