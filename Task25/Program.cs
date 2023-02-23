// Задача 25: Напишите цикл, который
// 1. принимает на вход два числав (А и В) и 
// 2. возводит число А в натуральную степень В.

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0) Console.WriteLine($"Число В должно быть натуральным");
else Result (numberA, numberB);

int Exponentiation(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }
    return res;
    // int res = 1;
    // int i=1;
    // while (i<=numB)
    // {
    //     res = res*numA;
    //     i++;
    // }
    // return res;
}
void Result (int numA, int numB)
{
   Console.WriteLine (Exponentiation (numA, numB));
}