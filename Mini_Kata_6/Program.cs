namespace Mini_Kata_6;

class Program
{
    static string[] enemyNames = ["Goblin", "Orc", "Troll"];
    static List<string> playerInventory = new List<string>{ "Sword", "Shield", "Potion"};
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enemies:");
        foreach (string enemy in enemyNames)
        {
            Console.WriteLine(enemy);
        }
        
        Console.WriteLine("\nPlayer Inventory:");
        playerInventory.ForEach(Console.WriteLine);
        
        playerInventory.Add("Helmet");
        
        Console.WriteLine("\nUpdated Inventory:");
        playerInventory.ForEach(Console.WriteLine);
        
    }
}