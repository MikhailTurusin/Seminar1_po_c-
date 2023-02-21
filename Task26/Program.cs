// Задача 26: Напишите программу, которая
// 1. принимает на вход число и
// 2. выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberofDigits(int num)
{
    int count = 1;
    if (num == 0) return count;
    else
    {
        while (num > 9)
           {
            num = num / 10;
            count = count + 1;
           }
    }
    return count;
}

int result1 = NumberofDigits(number);
Console.WriteLine(result1);