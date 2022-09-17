/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int array_size)
{
    int[] resultArray = new int[array_size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Prompt($"Введите {i} элемент массива");

    }
    return resultArray;
}

void displayArray(int[] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]} \t");
    }
    System.Console.WriteLine("]");
}
int size = Prompt("Введите размер массива > ");
int[] massiv = FillArray(size);


displayArray(massiv);