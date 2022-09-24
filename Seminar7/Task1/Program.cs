/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateArray(int rowLength, int colLength)
{
    var array = new double[rowLength, colLength];
    var rnd = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100), 2);

        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    System.Console.WriteLine("2-мерный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int colCount = Prompt("Введите количество столбцов > ");
int rowCount = Prompt("Введите количество строк> ");
double[,] array = GenerateArray(colCount, rowCount);
Print2DArray(array);