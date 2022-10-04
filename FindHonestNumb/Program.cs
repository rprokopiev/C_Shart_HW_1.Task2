Console.Write("Enter Number N: ");
string Number = Console.ReadLine();
int N = int.Parse(Number);
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
    
}
