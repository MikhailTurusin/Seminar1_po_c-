// Задача 42: Напишите программу, которая
// 1. будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10


int DecToBin(int num)
{
    int count = 1;
    int newNum = 0;
    while (num > 0)
    {
        newNum = newNum + num % 2 * count;
        num = num / 2;
        count = count * 10;
    }
    return newNum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = DecToBin(number);

Console.WriteLine(result);