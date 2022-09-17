/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
    int sum = 0;
    for (int i = 0; i <= array.Length-1; i=i+2)
    {
            chetnoe[i] = array[i];
            sum = sum+array[i];
            System.Console.WriteLine($"{chetnoe[i]} - Нечетная позиция!");
    }
    return sum;
    

}

int ArrayLength = Prompt("Введите длину массива > ");
int[] array = GenerateArray(ArrayLength);
int result = Main(array);

System.Console.WriteLine($" Cevvf элементов на нечетной позиции  - {result}");