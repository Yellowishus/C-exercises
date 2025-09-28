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
    switch (shape)
    {
        case "rock":
            return "rock";
        case "scisors":
            return "scisors";
        case "paper":
            return "paper";
        default:
            return "Sorry i didint recognised your word. Before trying again you wrote it without using capital-letters.";
    }
    
}