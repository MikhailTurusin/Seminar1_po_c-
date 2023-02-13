Console.Clear();
Console.WriteLine("Введите число: ");
string number = (Console.ReadLine());
if (number == "1")

    Console.WriteLine($"Заданный номер является Понедельником");
else if (number == "2")
{
    Console.WriteLine($"Заданный номер является Вторником");
}
else if (number == "3")
{
    Console.WriteLine($"Заданный номер является Средой");
}
else if (number == "4")
{
    Console.WriteLine($"Заданный номер является Четвергом");
}
else if (number == "5")
{
    Console.WriteLine($"Заданный номер является Пятницей");
}
else if (number == "6")
{
    Console.WriteLine($"Заданный номер является Субботой");
}
else if (number == "7")
{
    Console.WriteLine($"Заданный номер является Воскресеньем");
}
else
{
    Console.WriteLine($"Заданный номер не является днем недели");
}