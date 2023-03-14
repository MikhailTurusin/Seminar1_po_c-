// Задача 66:
// 1. Задайте значения M и N.
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// 3. Выполните с помощью рекурсии.

// M = 1; N = 15-> 120
// M = 4; N = 8-> 30

Console.WriteLine("Введите число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int number2 = int.Parse(Console.ReadLine());

int result = SumofNumbers(number1, number2);

Console.WriteLine(result);

int SumofNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        return num1 + SumofNumbers(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        return num1 + SumofNumbers(num1-1, num2);
    }
    else return num1;
}