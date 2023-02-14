/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int count = 0;

if (number <= 0)
{
    Console.WriteLine("Число должно быть больше 0");
}

while (count < number)
{   number1 = count + 1;

    if (number1 % 2 == 0)
    Console.WriteLine(number1);
    count++;
}