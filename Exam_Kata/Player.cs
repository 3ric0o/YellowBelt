namespace Exam_Kata;

public class Player : Character, ICombat
{
    public string Name {get;}
    private int _level;
    private readonly int _xpCap = 100;
    
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
        return _random.Next(10, _damage + BonusDamage + 1);
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
                          $"{Name}'s current health: {_currentHealth}\n");
        Console.ResetColor();
    }
    public void Heal()
    {
        int healAmount = _random.Next(1, _maxHealth);
        _currentHealth += healAmount;
        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
            
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Name} healed for {healAmount} HP!\n" +
                          $"{Name} is now {_currentHealth} health.");
        Console.ResetColor();
    }
    public int Roll()
    {
        int diceRoll = _random.Next(1, 11);
        return diceRoll;
    }

    public void GetExp(int xp)
    {
        _exp += xp;
        while (_exp >= _xpCap)
        {
            _exp -= 100;
            LevelUp();
        }
    }
    public void GetGold(int gold)
    {
        _gold += gold;
    }

    private void LevelUp()
    {
        _level++;
        _maxHealth += 25;
        _damage += 10;
        _currentHealth = _maxHealth;
        
        Console.WriteLine($"Player {Name} is now {_level} Level!\n" +
                          $"--> {_maxHealth} HP\n" +
                          $"--> {_damage} Damage\n");
    }
}
