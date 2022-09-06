Console.Write("Enter 1st number> ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter 2nd value>>");
int numB = int.Parse(Console.ReadLine() ?? "0");

if (numA < numB )
{
    Console.Write("Min -> ");
    Console.WriteLine(numA);
    Console.Write("Max -> ");
    Console.WriteLine(numB);

}
else 
{
    Console.Write("Min -> ");
    Console.WriteLine(numB);
    Console.Write("Max -> ");
    Console.WriteLine(numA);
}

