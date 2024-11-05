namespace Kata_6;

class Program
{
    static string[] enemyNames = { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" };
    static List<string> playerInventory = new List<string> {"Sword", "Shield", "Potion"};
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
        playerInventory.Add("Armor");
        playerInventory.Remove("Potion");
        
        Console.WriteLine("\nUpdated Inventory:");
        playerInventory.ForEach(Console.WriteLine);
        
    }
}