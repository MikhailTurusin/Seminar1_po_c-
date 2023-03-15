// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m=3, n = 2->A(m, n) = 29

Console.WriteLine("Введите неотрицательное число m: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int number2 = int.Parse(Console.ReadLine());

if (number1<0 || number2<0) Console.WriteLine("Числа должны быть положительные");
else
{
Console.Write("A(m, n) = ");
Console.WriteLine(FunctionAkkermana(number1,number2));
}

int FunctionAkkermana(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num2 == 0) return FunctionAkkermana(num1-1, 1);
    return FunctionAkkermana(num1-1, FunctionAkkermana(num1, num2-1));
}