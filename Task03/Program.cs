Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Weekend (int num)
{
            if (num > 5 && num < 8) Console.WriteLine ("Выходной день");
            else Console.WriteLine ("Будний день");
            return num;
}

if (number > 0 && number < 8) Weekend (number);
else Console.WriteLine ("Введеное число не является днем недели");