﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

bool Square(int num1, int num2)
{
    return num1*num1==num2 || num2*num2==num1;
}

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (Square(number1, number2)) Console.WriteLine("da");
else Console.WriteLine("no");