// Задача 27: Напишите программу, которая
// 1. принимает на вход число и
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumofDigits(number);
Console.WriteLine(result);

int SumofDigits(int num)
{
    int count=NumberofDigits(num);
    int sum=0;
    for (int i = 1; i <= count; i++)
    {
            sum=sum+num%10;
            num=num/10;
    }
    return sum;
}

int NumberofDigits(int num)
{
    int count = 1;
    if (num == 0) return count;
    else
    if(num>0)
        {
            while (num > 9)
            {
                num = num / 10;
                count = count + 1;
            }
        }
    else
    {
            while (num < -9)
            {
                num = num / 10;
                count = count + 1;
            }
        }
    return count;
}