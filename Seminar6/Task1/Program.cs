/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/


int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int input = Prompt("Введите количество цифр: > ");
int[] Main(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} число > ");
    }
    return array;
}

int Analize(int[] array)
{
    int negativeCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            negativeCount++;
        }
    }
    return negativeCount;
}

int[] analizeArray = Main(input);
System.Console.WriteLine(Analize(analizeArray));