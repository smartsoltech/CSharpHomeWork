/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int size)
{
    int[] numbers = new int[size];
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
        System.Console.Write($"{numbers[i]} ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    return numbers;
}

int Main(int[] array)
{
    int[] chetnoe = new int[array.Length];
    int count = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] % 2 == 0)
        {
            chetnoe[i] = array[i];
            count++;
            System.Console.WriteLine($"{chetnoe[i]} - Четное число!");
        }
    }
    return count;

}

int ArrayLength = Prompt("Введите длину массива > ");
int[] array = GenerateArray(ArrayLength);
int result = Main(array);

System.Console.WriteLine($" Количество четных элементов - {result}");