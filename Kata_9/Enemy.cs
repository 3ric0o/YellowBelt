namespace Kata_9;

public class Enemy
{
    public string Type { get; private set; }
    private int _health;
    private int _damage;

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        _health = health;
        _damage = damage;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {_health}");
    }
}