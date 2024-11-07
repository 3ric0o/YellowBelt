namespace Exam_Kata;

public class Player : Character, ICombat
{
    public string Name {get;}
    private int _level;
    
    public Player(string name, int maxHealth = 100, int level = 1, int exp = 0, int gold = 0, int damage = 20) : 
        base(maxHealth, damage, exp, gold)
    {
        Name = name;
        _level = level;
       
    }

    public int DealDamage(string? enemyType)
    {
        int damage = DamageCalculator();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{Name} attacks {enemyType} for {damage} Damage!");
        Console.ResetColor();
        return damage;
    }
    public int DamageCalculator()
    {
        return _random.Next(1, _damage+1);
    }
    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            IsAlive = false;
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Player {Name} takes {damage} Damage!\n" +
                          $"\n{Name}'s current health: {_currentHealth}\n");
        Console.ResetColor();
    }
    public void Heal()
    {
        int healAmount = _random.Next(1, _maxHealth);
        _currentHealth += healAmount;
        if (_currentHealth > _maxHealth)
        {
            _maxHealth = _currentHealth;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Name} healed for {healAmount} HP!\n" +
                          $"{Name} is now {_currentHealth} health.");
        Console.ResetColor();
    }
}
