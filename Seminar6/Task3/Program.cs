/*
Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2
*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rowCount = Prompt("Введите число строк> ");
int colCount = Prompt("Введите количество стольбцов> ");
int minRnd = Prompt("Введите минимум рандома> ");
int maxRnd = Prompt("Введите максимум рандома> ");

int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minRange, maxRange + 1);

        }
    }
    return array;
}

void Print2DArray(int[,] array)
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

void PrintArray(int[] array)
{
    System.Console.WriteLine("Массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}

int[] MinValues(int[,] array)
{
    int[] resultArray = new int[rowCount];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int minLine = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k=0; k<resultArray.Length; k++)
            {
            if (array[i, j] < minLine)
            {
                minLine = array[i, j];
                resultArray[k] = resultArray[k]+minLine;
            }
            }
        }
        Console.WriteLine("Строка {0}, значение: {1}", i, minLine);
        Console.WriteLine();
        for (int k = 0; k < resultArray.Length; k++)
        {
            resultArray[k] = minLine;
        }
    }
    return resultArray;
}

int[] MaxValues(int[,] array)
{
    int[] resultArray = new int[rowCount];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxLine = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k=0; k<resultArray.Length; k++)
            {
            if (array[i, j] > maxLine)
            {
                maxLine = array[i, j];
                resultArray[k] = resultArray[k]+maxLine;
            }
            }
        }
        Console.WriteLine("Строка {0}, значение: {1}", i, maxLine);
        Console.WriteLine();
        for (int k = 0; k < resultArray.Length; k++)
        {
            resultArray[k] = resultArray[k]+maxLine;
        }
    }
    return resultArray;
}
int[,] tmpArray = GenerateArray(rowCount, colCount, minRnd, maxRnd);
int[] minArray = MinValues(tmpArray);
int[] maxArray = MaxValues(tmpArray);

Print2DArray(tmpArray);
System.Console.WriteLine();
PrintArray(minArray);
PrintArray(maxArray);



