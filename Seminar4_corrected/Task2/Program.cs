/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int input = Prompt("Введите число > ");
System.Console.WriteLine($"Введенное число: {input}");
double Main(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number = number/10;
    }
    return sum;
}

   Console.WriteLine("Сумма чисел равна " + Main(input));