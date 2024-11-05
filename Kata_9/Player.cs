namespace Kata_9;

public class Player
{
    public int Damage { get; private set; }
    private string _name;
    private int _health;
    private int _level;

    public Player(string name, int health, int level, int damage)
    {
        _name = name;
        _health = health;
        _level = level;
        Damage = damage;
    }

    public void Attack(string target, int damage)
    {
       _health -= damage;
       Console.WriteLine($"{_name} attacked {target} and deals {damage} damage");
    }
}