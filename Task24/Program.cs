// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и
// 2. выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int sum = 0;
    for (int index = 1; index <= num; index++)
    {
        sum = sum + index;
    }
    return sum;
}

int result= Sum(number);
Console.WriteLine ($"Сумма чисел от 1 до {number} = {result}");