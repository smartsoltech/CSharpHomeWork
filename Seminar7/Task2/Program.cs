// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateArray()
{
    var rnd = new Random();
    var array = new double[rnd.Next(3, 10), rnd.Next(3, 10)];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100), 2);
            //System.Console.WriteLine(array[i,j]);
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

bool PositionCheck(double[,] array, int colPos, int rowPos);
{
    if (colPos != array.GetLenght(0))
    {
        System.Console.WriteLine($"Столбец {colPos} отсуствует");
        return false;
    }
    if (rowPos != array.GetLength(1))
    {
        System.Console.WriteLine($"Столбец {colPos} отсуствует");
        return false;
    }
    return true;

}

void Result(bool status, double[,] array, int colPos, int rowPos)
{
    if(status)
    {
        System.Console.WriteLine(array[colPos, rowPos]);
    }
    else System.Console.WriteLine("Нет такой позиции");
}
double[,] array = GenerateArray();
Print2DArray(array);
int colPos = Prompt("Введите номер столбца> ");
int rowPos = Prompt("Введите номер строки> ");
bool checkResult = PositionCheck(array, colPos, rowPos);
Result(checkResult, array, colPos, rowPos);

