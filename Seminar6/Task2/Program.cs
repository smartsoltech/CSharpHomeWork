/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = Prompt("Введите значение B1> ");
double k1 = Prompt("Введите значение K1> ");
double b2 = Prompt("Введите значение B2> ");
double k2 = Prompt("Введите значение K2> ");

double CrossLineCalc(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    return x;
}

double x = CrossLineCalc(b1,b2,k1,k2);
System.Console.WriteLine($"Точка пересечения: {x}");

