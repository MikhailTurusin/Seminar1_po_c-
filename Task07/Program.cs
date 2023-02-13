//7. Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
if (number >= 100 && number <= 999)
{
    number1 = number % 10;
    Console.Write($"Последняя цифра числа {number1}");
}
else
{
    Console.Write("Вы ввели не трехзначное число");
}