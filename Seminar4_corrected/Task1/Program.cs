//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int digit = Prompt("Введите число > ");
int pow = Prompt("Введите степень > ");

void Display(int digit, int pow)
{
    long itog = 0;
    double res = 0;
    for (int i = 0; i <= pow; i++)
    {
        itog = Convert.ToUInt32(Math.Pow(digit, pow));
        res *= digit;
    }
    System.Console.WriteLine($"Число {digit} в степени {pow} = {itog}, tmp_itog = {res}");

    /*              xPow = x;
                for (int o = 0; o < n; o++)
                {
                    xPow *= x;
                }
                step *= (-t * x) / ((2*i)*(2 * i + 1));
                S += step;
                
    */

}
Display(digit, pow);