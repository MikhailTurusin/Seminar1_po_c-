// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверят, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend (int num)
{
    return num > 5;
}

Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number < 1 | number > 7) Console.WriteLine ("Вы ввели некорректную цифру");
else
    if (Weekend(number)) Console.WriteLine ($"Введенная цифра {number} => выходной день");
    else Console.WriteLine ($"Введенная цифра {number} => будний день");