int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int input = Prompt("Введите число (5 символов)> ");

void Polyndrom(int digit)
{
    //Получаем длину введенного числа (работа со строкой)
    string inputLength = Convert.ToString(digit);
    Console.WriteLine($"Длина введенного числа - {inputLength.Length} знаков");
    int[] origin = new int[6];
    if (inputLength.Length < 5 || inputLength.Length >5 )
    {
       System.Console.WriteLine("Не верная длина числа");     
    }
    else 
    {
        if (digit )
    }
}
Polyndrom(input);