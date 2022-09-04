System.Console.WriteLine("Введите 2-3-х значное число> ");
int value = int.Parse(Console.ReadLine() ?? "0");
int tmp_value = value % 10;
if ((value / 100) > 10)
{
    System.Console.WriteLine($"Введеное число: {value} имеет 4 цифры. Не буду считать!");
}
else if (((value / 10) == 0) || ((value / 10) < 10))
{
    System.Console.WriteLine($"Введеное число: {value}, Двузначное. Третьей цифры нет");
}
else if (((value/100) > 0) || ((value / 100) < 10))
{
    System.Console.WriteLine($"Введеное число: {value} Трех-значное, Последняя цифра - {tmp_value}, Первая цифра - {value / 100}");
}
