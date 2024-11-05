namespace Mini_Kata_7;

public class Player
{
    private static string _name;
    private static int _health;
    private static int _level;

    public Player(string name, int health, int level)
    {
        _name = name;
        _health = health;
        _level = level;
    }

    public static void PlayerInfo()
    {
        Console.WriteLine($"Player Info:\n" +
                          $"Name: {_name}\n" +
                          $"Health: {_health}\n" +
                          $"Level: {_level}");
    }
}