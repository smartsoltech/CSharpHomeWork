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

int tmp_len = input;
int sum = 0;
while (input < 0)
{
    tmp_len = input / 10;
    sum += tmp_len;
    //return sum;
    System.Console.WriteLine(sum);

}