/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.Clear ();
Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write ("Число является чётным? -> да");
}
else
{
    Console.Write ("Число является чётным? -> нет");
}