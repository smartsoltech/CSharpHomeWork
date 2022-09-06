int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int input = Prompt("Введите число (5 символов)> ");

void Polyndrom(int value)
{
    //Получаем длину введенного числа (работа со строкой)
    string inputLength = Convert.ToString(value);
    Console.WriteLine($"Длина введенного числа - {inputLength.Length} знаков");
    int temp = value;
    int rev = 0;
    while (value>0)
    {
        int dig = value % 10;
        rev = rev * 10 + dig;
        value  = value / 10;
    }
if(temp == rev)
{
    System.Console.WriteLine("Это палиндром!");
}
else
{
    System.Console.WriteLine("Это не палиндром!");
}
}
Polyndrom(input);