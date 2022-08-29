Console.Write("Enter a digit> ");
int value = int.Parse(Console.ReadLine() ?? "0");
int i = 0;
for (i=1; i<=value; i++)
{
    if (i%2==0) 
    {
       Console.Write(" ");
       Console.Write(i);

    }
    
}