// Задача 36:
// 1. Задайте одномерный массив, заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumofElements (int[]arr)
{
    int sumofelements=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2!=0) sumofelements+=arr[i];
    }
    return sumofelements;
}

int[] array=CreateArrayRndInt(5, -5, 15);
PrintArray (array);

int result=SumofElements(array);
Console.Write($" -> {result}");