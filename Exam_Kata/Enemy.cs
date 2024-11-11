namespace Exam_Kata;

public class Enemy : Character, ICombat
{
    public readonly string Type;
    
    public Enemy(string type, int maxHealth, int damage, int exp, int gold) :
        base(maxHealth, damage, exp, gold)
    {
        Type = type;
        
    }
    
    public int DealDamage(string? playerName)
    {
        int damage = DamageCalculator();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{Type} attacks {playerName} for {damage} Damage!");
        Console.ResetColor();
        Thread.Sleep(1000);
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

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Enemy {Type} takes {damage} Damage!\n");
        Console.ResetColor();
    }

    public int GiveExperience()
    {
        return _exp;
    }

    public int GiveGold()
    {
        return _gold;
    }
    
}