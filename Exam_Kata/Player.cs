namespace Exam_Kata;

public class Player : ICombat
{
    public string? Name {get;}
    private int _maxHealth;
    private int _currentHealth;
    private int _damage;
    
    
    private int _level;
    private int _experience;
    private int _gold;
    
    public bool IsAlive = true;
    private readonly Random _random = new Random();
    
    
    public Player(string? name, int maxHealth, int level, int experience, int gold, int damage)
    {
        Name = name;
        _maxHealth = maxHealth;
        _currentHealth = _maxHealth;
        _level = level;
        _experience = experience;
        _gold = gold;
        _damage = damage;
    }

    public int DealDamage(string? enemyType)
    {
        int damage = DamageCalculator();
        Console.WriteLine($"{Name} attacks {enemyType} for {damage} Damage!");
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
        Console.WriteLine($"Player {Name} takes {damage} Damage!\n" +
                          $"{Name}'s current health: {_currentHealth}\n");
    }
    public void Heal()
    {
        int healAmount = _random.Next(1, _maxHealth);
        _currentHealth += healAmount;
        if (_currentHealth > _maxHealth)
        {
            _maxHealth = _currentHealth;
        }
        
        Console.WriteLine($"{Name} healed for {healAmount} HP!\n" +
                          $"{Name} is now {_currentHealth} health.");
    }
}
