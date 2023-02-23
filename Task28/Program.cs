// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int factorial = 1;
    for (int index = 1; index <= num; index++)
    {
        factorial = factorial * index;
    }
    return factorial;
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Factorial(number);

if (number > 0) Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");
else Console.WriteLine("Введено не натуральное число");