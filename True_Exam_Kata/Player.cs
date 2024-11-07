namespace True_Exam_Kata;

public class Player
{
    public string? Name { get; private set; }
    private int _maxHealth;
    private int _currentHealth;
    private int _level;
    private int _experience;
    private int _gold;
        
    public bool IsAlive = true;
    private readonly Random _random = new Random();
        
    public Player(string? name, int maxHealth, int level, int experience, int gold)
    {
        Name = name;
        _maxHealth = maxHealth;
        _currentHealth = _maxHealth;
        _level = level;
        _experience = experience;
        _gold = gold; 
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
}