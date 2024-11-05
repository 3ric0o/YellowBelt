

namespace Mini_Kata_7_1;

public class Enemy
{
    public string Type {get;}
    private int _health;
    public int ExpGiven {get; private set;}

    public Enemy(string type, int health, int expGiven)
    {
        Type = type;
        _health = health;
        ExpGiven = expGiven;
    }
    
    public void TakeDamage(int damage)
    {
        _health -= damage;
        
        if (_health <= 0)
        {
            _health = 0;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{Type} takes {damage} damage. Remaining Health: {_health}\n");
        
        Thread.Sleep(1000);
        
        if (_health == 0)
        {
         Console.WriteLine("You have Slain the Orc!");
         Thread.Sleep(1000);
        }
    }

    public bool IsAlive()
    {
        return _health > 0;
    }
    
}