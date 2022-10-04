Console.Write("Enter Number N: ");
string Number = Console.ReadLine();
int N = int.Parse(Number);
if(N % 2 == 0)
{
    Console.Write("Honest number");
}
else
{
    Console.Write("Odd number");
}
