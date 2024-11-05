namespace Mini_Kata_7;

class Program
{
    static void Main(string[] args)
    {
        var Player = new Player("Arin", 100, 1);
        var Goblin = new Enemy("Goblin", 50, 10);

        Player.PlayerInfo();
        
        Console.WriteLine();
        
        Enemy.EnemyInfo();
    }
}