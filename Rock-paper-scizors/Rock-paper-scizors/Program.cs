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
    Random rnd = new Random();
    int oponentShape = rnd.Next(3); //oponentShape is one of three posible shapes 0=rock 1=paper 2=scisors 
    Console.WriteLine(oponentShape);
    Console.WriteLine("Lets play Rock-Paper-Scisors game:");
    Console.WriteLine("Please type your choice");
    string shape = Console.ReadLine();
    switch (shape)
    {
        case "rock":
            return "rock";
        case "paper":
            return "paper";
        case "scisors":
            return "scisors";
        default:
            return "Sorry i didint recognised your word. Before trying again make sure you wrote it without using capital-letters.";
    }
    
}