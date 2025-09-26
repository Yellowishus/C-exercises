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
            float distanceFromLeft = (float.Parse(bushNumber) / 2);
            for (int i = 0; i < int.Parse(bushNumber); i++)
            {
                float NOfSpaces = distanceFromLeft;
                while (NOfSpaces > 0)
                {
                    Console.Write(" ");
                    NOfSpaces--;
                }
                for (int j = 0; j <= i; j++)
                {
                    
                    Console.Write("*");
                }
                Console.Write("\n");
                distanceFromLeft--;
            }
            
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("You need to write proper number.");
    }
}