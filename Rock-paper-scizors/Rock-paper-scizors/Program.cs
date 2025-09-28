// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine(RPSGame());
}
catch (FormatException fEm)
{
    Console.WriteLine( fEm.Message );
}
string RPSGame()
{
    Console.WriteLine("Lets play Rock-Paper-Scisors game:");
    Console.WriteLine("Please type your choice");
    string shape = Console.ReadLine();
    return shape;
}