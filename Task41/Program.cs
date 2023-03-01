// Задача 41:
// 1. Пользователь вводит с клавиатуры М чисел.
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int[] NumberofNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountingNumbers(int[]arr)
{
    int count=0;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]>0) count++;
    }
    return count;
}

Console.Write("Сколько чисел Вы хотите ввести: ");
int number = Convert.ToInt32(Console.ReadLine());

int []array=NumberofNumbers(number);
PrintArray(array);
int result=CountingNumbers(array);
Console.WriteLine($" -> {result}");