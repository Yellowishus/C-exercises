// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine(RPSGame());
}
catch (FormatException fEm)
{
    Console.WriteLine(fEm.Message);
}
string RPSGame()
{
    Random rnd = new Random();
    int oponentShape = rnd.Next(3); //oponentShape is one of three posible shapes 0=rock 1=paper 2=scisors 
    Console.WriteLine("Lets play Rock-Paper-Scisors game:");
    Console.WriteLine("Please type your choice");
    string shape = Console.ReadLine();
    if (shape == "rock")
    {
        if (oponentShape == 2)
        {
            return messages("victory");
        }
        else if (oponentShape == 1)
        {
            return messages("defeat");
        }
        else if (oponentShape == 0)
        {
            return messages("draw");
        }
        else
        {
            return messages("error");
        }
    }
    else if (shape == "paper")
    {
        if (oponentShape == 0)
        {
            return messages("victory");
        }
        else if (oponentShape == 2)
        {
            return messages("defeat");
        }
        else if (oponentShape == 1)
        {
            return messages("draw");
        }
        else
        {
            return messages("error");
        }
    }
    else if (shape == "scisors")
    {
        if (oponentShape == 1)
        {
            return messages("victory");
        }
        else if (oponentShape == 0)
        {
            return messages("defeat");
        }
        else if (oponentShape == 2)
        {
            return messages("draw");
        }
        else
        {
            return messages("error");
        }
    }
    else
    {
        return messages("error");
    }

}
string messages(string result)
{
    string victoryMessage = "Congratulations you won!";
    string defeatMessage = "Unfortunatly you lost!";
    string drawMessage = "Draw!!!";
    string errorMessage = "You did something wrong try again!";
    if (result == "victory")
    {
        return victoryMessage;
    }
    else if (result == "defeat")
    {
        return defeatMessage;
    }
    else if (result == "draw")
    {
        return drawMessage;
    }
    else if (result == "error")
    {
        return errorMessage;
    }
    else
    {
        return errorMessage;
    }
}