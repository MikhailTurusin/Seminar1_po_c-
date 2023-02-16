// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit (int num)
{
        int secondDigit = num / 10;
    return secondDigit % 10;
}

Console.Write ("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>999 || number<100) Console.Write("Вы ввели не трехзначное число");
else
{
int result = SecondDigit(number);

Console.Write($"Вторая цифра числа {number} -> {result}");
}