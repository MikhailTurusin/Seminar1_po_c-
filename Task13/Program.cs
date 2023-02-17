// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

bool Proverka(int num)
{
    return num < 100 && num > -100;
}

int ThirdDigit(int num)
{
    if (num > 0)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        return num % 10;
    }
    else
    {
        while (num < -999)
        {
            num = num / 10;
        }
        return num % 10;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Proverka(number)) Console.WriteLine("третьей цифры нет");
else
{
    int result = ThirdDigit(number);
    Console.WriteLine($"Третья цифра -> {result}");
}