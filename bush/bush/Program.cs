// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
bool tryAgain = true;
while (tryAgain)
{
    try
    {
        Console.WriteLine("How big do you want your bush to be?");
        bushPrinter();
        tryAgain = false;

        void bushPrinter()
        {
            string bushNumber = Console.ReadLine();
            for (int i = 0; i < int.Parse(bushNumber); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("You need to write proper number.");
    }
}