namespace Mini_Kata_7;

public class Enemy
{
    static string _type;
    static int _health;
    static int _damage;

    public Enemy(string type, int health, int damage)
    {
        _type = type;
        _health = health;
        _damage = damage;
    }

    public static void EnemyInfo()
    {
        Console.WriteLine($"Enemy info:\n" +
                          $"Type: {_type}\n" +
                          $"Health: {_health}\n" +
                          $"Damage: {_damage}");
    }
}