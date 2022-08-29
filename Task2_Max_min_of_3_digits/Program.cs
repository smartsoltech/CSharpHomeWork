Console.Write("Enter 1st number> ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter 2nd digit>>");
int numB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter 3rd digit>>");
int numC = int.Parse(Console.ReadLine() ?? "0");

int min = 0;
int max = 0;
if (numA < numB )
{
    min = numA;
    max = numB;
}
else
{
    min = numB;
    max = numA;
}
if (numC>max)
{
    min = min;
    max = numC;
}
else 
{
    min = numC;
    max = max;
}
    Console.Write("Min -> ");
    Console.WriteLine(min);
    Console.Write("Max -> ");
    Console.WriteLine(max);

