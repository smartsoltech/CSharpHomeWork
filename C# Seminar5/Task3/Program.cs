int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
float[] GenerateArray(int size)
{
    float[] numbers = new float[size];
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1.00, 999.99);
        System.Console.Write($"{numbers[i]} ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    return numbers;
}
int arrayLength = Prompt("Введите длину массива > ");
float[] array = GenerateArray(arrayLength);
for (int i=0; i<array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}