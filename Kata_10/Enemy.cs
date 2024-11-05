namespace Kata_10;

public class Enemy : ICombat
{
    public string Type { get; private set; }
    private int _health;
    private int _damage;
    private ICombat _combatImplementation;

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

    public void Attack(string target, int damage)
    {
        _health -= damage;
        Console.WriteLine($"{Type} attacked {target} and deals {damage} damage");
    }
}