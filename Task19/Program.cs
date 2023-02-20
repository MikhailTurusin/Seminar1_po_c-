// Задача 19. Напишите программу, которая
// 1. принимает на вход пятизначное число и
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Negative(int num)
    {
    if (num > 0) return num > 9999 && num < 100000;
    else return num < -9999 && num > -100000;
    }

bool Palindrome (int num)
{
    int firstDigit = num / 10000;
    int fifthDigit = num % 10;
    int secondDigit = num / 1000;
    int secondDigit1 = secondDigit % 10;
    int fourthDigit = num % 100;
    int fourthDigit1 = fourthDigit / 10;
    return firstDigit==fifthDigit && secondDigit1==fourthDigit1;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0) Console.Write ("Введенно не 5ти значное число");
else
{
    if (Negative(number))
        if (Palindrome(number)) Console.Write("Введенное число является палиндромом");
        else {Console.Write ("Введен не палиндром");}
    else
        if (Palindrome(number)) Console.Write("Введенное число является палиндромом");
        else {Console.Write ("Введенно не 5ти значное число");}
}