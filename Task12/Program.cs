/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

/* Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int number3 = number1 % number2;

if (number1 % number2 == 0) Console.Write($"число {number1} кратно числу {number2}");
else Console.Write($"число {number1} не кратно числу {number2}, остаток -> {number3}"); */

int Remains(int number1, int number2)
{
    int remains = number1 % number2;
    return remains;
}

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int rem = Remains(num1, num2);

if (rem == 0) Console.WriteLine("Числа кратны");
else Console.WriteLine($"Числа не кратны остаток от деления равен {rem}");