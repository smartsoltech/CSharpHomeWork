//Функция ввода данных и возврат введенного значения
int Prompt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

//вызов фунции на ввод числа
int value = Prompt("Введите число > ");
System.Console.WriteLine(" ");
System.Console.WriteLine($"Таблица 'Кубов' числа {value}:");
//System.Console.WriteLine(" ");
//функция вычисления кубов и вывода результата
void main(int value)
{
    for (int i=1; i<=value; i++)
    {
        System.Console.WriteLine($"{i} ^ 3 = {(long) Math.Pow(i, 3)}");
    }
}

//Вызов основной функции
main(value);