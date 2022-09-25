// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Генерация массива рандомного размера
double[,] GenerateArray()
{
    var rnd = new Random();
    var array = new double[rnd.Next(3, 10), rnd.Next(3, 10)];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100), 2);
        }
    }
    return array;
}
//Вывод массива на экран
void Print2DArray(double[,] array)
{
    System.Console.WriteLine("Сгенерированный массив: ");
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

//Проверка введенных координат элемента на наличие позиции в массиве
bool PositionCheck(double[,] array, int colPos, int rowPos)
{
    if (colPos < array.GetLength(0) && rowPos < array.GetLength(1))
    {
        System.Console.WriteLine($"Столбец {colPos} отсуствует");
        return true;
    }
    return false;
}

//Вывод результата на экран
void Result(bool status, double[,] array, int colPos, int rowPos)
{
    if(status)
    {
        System.Console.WriteLine($"Элемент с координатами {colPos}, {rowPos} имеет значение: {array[rowPos, colPos]}");
    }
    else System.Console.WriteLine("Нет такой позиции");
}
double[,] array = GenerateArray();
Print2DArray(array);
int colPos = Prompt("Введите номер столбца> ");
int rowPos = Prompt("Введите номер строки> ");
bool checkResult = PositionCheck(array, colPos, rowPos);
Result(checkResult, array, colPos, rowPos);

