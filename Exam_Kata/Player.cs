namespace Exam_Kata;

public class Player(string name, int maxHealth = 100, int level = 1, int exp = 0, int gold = 0, int damage = 20)
    : Character(maxHealth, damage, exp, gold), ICombat
{
    public string Name { get; } = name;
    private int _level = level;
    private readonly int _xpCap = 100;
    private List<Item> Inventory { get; set; } = new();

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
        return Random.Next(10, _damage + BonusDamage + 1);
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
        int healAmount = Random.Next(1, _maxHealth);
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
        int diceRoll = Random.Next(1, 11);
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

    public void AddItem(Item item)
    {
        Inventory.Add(item);
        Console.WriteLine($"{item.Name} has been added to your inventory!");
    }

    public bool SpendGold(int amount)
    {
        if (_gold >= amount)
        {
            _gold -= amount;
            return true;
        }
        Console.WriteLine("You don't have enough gold!");
        return false;
    }
}

