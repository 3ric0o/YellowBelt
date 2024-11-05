namespace Kata_8;

public class Player
{
    public int Damage {get; private set;}
    public int Exp {get; private set;}
    public string Name {get;}
    
    private int _health;
    private int _level;
    private int _levelUpThreshold = 100;
    
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
        
        if (Exp >= _levelUpThreshold)
        {
            Exp -= _levelUpThreshold;
            LevelUp();
        }
    }

    public void LevelUp()
    {
        _level++;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"\n{Name} leveled up!\n" +
                          $"{Name} is now {_level} level with {Exp}\n");
        Console.ResetColor();
        Thread.Sleep(1000);
    }
}