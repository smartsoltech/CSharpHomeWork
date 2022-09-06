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
    while (temp>0)
    {
        int dig = temp % 10;
        //System.Console.WriteLine($"dig = {dig}"); Отладочный принт
        rev = rev * 10 + dig;
        //System.Console.WriteLine($"rev = {rev}"); Отладочный принт
        temp  = temp / 10;
        //System.Console.WriteLine($"temp = {temp}"); Отладочный принт
    }
    
    if(value == rev)
    {
        System.Console.WriteLine($"Число {value} - это палиндром!");
    }
    else
    {
        System.Console.WriteLine($"Число {value} - это не палиндром!");
    }
}
Polyndrom(input);