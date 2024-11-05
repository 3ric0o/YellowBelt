namespace Exam_Kata;

class Program
{
    static void Main(string[] args)
    {
        Program dungeonCrawler = new();
        dungeonCrawler.GameStart();
        string playerName = dungeonCrawler.PlayerName();
        var player = new Player(playerName, 100, 1, 0,0);
    }

    void GameStart()
    {
        Console.WriteLine("Hi! You will play a quick Text_Based Dungeon Crawler!");
        Thread.Sleep(1000);
        Console.WriteLine("What would you like to name your character?");
        
    } 
    string PlayerName()
    {
        string nameInput;
        while (true)
        {
            nameInput = Console.ReadLine();

            // Check if the name contains spaces or is invalid (empty or whitespace)
            if (string.IsNullOrWhiteSpace(nameInput) || nameInput.Contains(' '))
            {
                Console.WriteLine("Invalid input. Please enter a single word for your character's name.");
            }
            else
            {
                // Exit the loop if the name is valid
                break;
            }
        }
        Console.WriteLine($"Character name set to: {nameInput}");
        return nameInput;
    }
}

        

    