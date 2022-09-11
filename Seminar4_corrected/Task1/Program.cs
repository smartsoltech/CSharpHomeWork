//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


double Pow(int digit, int pow)
{
    double result = 1;
    for (int i = 0; i < pow; i++)
    {
        result *= digit;

    }
return result;
}

void Display(int digit, int pow, double number)
{
    System.Console.WriteLine($"{digit} в степени {pow}  =  {number}");
}

int digit = Prompt("Введите число > ");
int pow = Prompt("Введите степень > ");

Display(digit, pow, Pow(digit, pow));
