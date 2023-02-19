// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Square (int num)
{
    int count=1;
    while (count<=num)
    {
        Console.WriteLine($"{count,5 } {Math.Pow(count, 3), 15}");
        count++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Square (number);