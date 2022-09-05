//Функция ввода данных и возврат введенного значения
int Prompt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

//вызов фунции на ввод числа
int digit = Prompt("Введите число > ");

//функция вычисления кубов и вывода результата
void main(int value)
{
    for (int i=1; i<=value; i++)
    {
        System.Console.WriteLine($"{i} ^ 3 = {(long) Math.Pow(i, 3)}");
    }
}

//Вызов основной функции
main(digit);