namespace Exam_Kata;

public class Enemy : ICombat
{
    private readonly string _type;
    private int _maxHealth;
    private int _currentHealth;
    
    private int Damage {get;}
    private int _expGive;
    private int _goldGive;
    
    public bool IsAlive = true;
    private readonly Random _random = new Random();
    
    
    public Enemy(string type, int maxHealth, int damage, int expGive, int goldGive)
    {
        _type = type;
        _maxHealth = maxHealth;
        _currentHealth = _maxHealth;
        Damage = damage;
        _expGive = expGive;
        _goldGive = goldGive;
    }
    
    public int DealDamage(string? playerName)
    {
        int damage = DamageCalculator();
        Console.WriteLine($"{_type} attacks {playerName} for {damage} Damage!");
        return damage;
    }
    public int DamageCalculator()
    {
        return _random.Next(1, Damage+1);
    }
    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            IsAlive = false;
        }
        Console.WriteLine($"Enemy {_type} takes {damage} Damage!\n" +
                          $"{_type}'s current health: {_currentHealth}\n");
    }
    public void Heal()
    {
        int healAmount = _random.Next(1, _maxHealth);
        _currentHealth += healAmount;
        if (_currentHealth > _maxHealth)
        {
            _maxHealth = _currentHealth;
        }
        
        Console.WriteLine($"{_type} healed for {healAmount} HP!\n" +
                          $"{_type} is now {_currentHealth} health.");
    }
}