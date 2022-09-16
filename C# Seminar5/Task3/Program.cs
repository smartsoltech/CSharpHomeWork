using System.Linq;
int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double[] GenerateArray(int size)
{
    double[] numbers = new double[size];
    System.Console.Write("[");
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100), 2);

        System.Console.Write($"{numbers[i]} | ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальный элемент: {numbers.Min()}, Максимальный элемент: {numbers.Max()}, разница между ними: {Math.Round(numbers.Max() - numbers.Min(),2)}");
    return numbers;
}

int arrayLength = Prompt("Введите длину массива > ");
double[] numbers = GenerateArray(arrayLength);





