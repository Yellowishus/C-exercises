// See https://aka.ms/new-console-template for more information
Console.WriteLine("How big do you want your bush to be?");
string bushNumber = Console.ReadLine();
bushPrinter(int.Parse(bushNumber));
void bushPrinter(int bushWidth)
{
    for (int i = 0; i < bushWidth; i++)
    {
        int j = 0;
        while (j <= i)
        {
            Console.Write("*");
            j++;
        }
        Console.Write("\n");
    }
}
