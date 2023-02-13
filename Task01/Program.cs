Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
        
        if (number == number1 * number1)
        {
            Console.WriteLine($"Число {number} является квадратом числа {number1}");
        }
        else
        {
        Console.WriteLine($"Число {number} не является квадратом числа {number1}");
        }