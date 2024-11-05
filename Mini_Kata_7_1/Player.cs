namespace Mini_Kata_7_1;

public class Player
{
    public int Damage {get; private set;}
    public string Name {get; private set;}
    public int Exp {get; private set;}
    
    private int _health;
    private int _level;
    
    public Player(string name, int health, int level, int exp, int damage)
    {
        Name = name;
        Damage = damage;
        _health = health;
        _level = level;
        Exp = exp;
    }

    public void Attack(int damage, string enemyType)
    {
        _health -= damage;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Player {Name} attacks the {enemyType} and deals {damage} damage");
        Thread.Sleep(1000);
    }
    public void GainExperience(int experience)
    {
        Exp += experience;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Player {Name} gains {experience} experience");
        Thread.Sleep(1000);
    }
}