// Задача 64:
// 1. Задайте значение N.
// 2. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// 3. Выполните с помощью рекурсии.

// N= 5-> "5, 4, 3, 2, 1"
// N= 8-> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());

if (number <= 0) Console.WriteLine("Введите число больше 0");
else
{
    Console.Write ("'' ");
    AllElements(number);
    Console.Write (" ''");
}

void AllElements(int num)
{
    if (num > 1)
    {
        Console.Write($"{num}, ");
        AllElements(num - 1);
    }
    else Console.Write($"{num}");
}