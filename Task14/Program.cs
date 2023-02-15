/* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

bool Squar(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (Squar(number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");