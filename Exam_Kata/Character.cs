namespace Exam_Kata;

public abstract class Character
{
    protected int _maxHealth;
    protected int _currentHealth;
    protected int _damage;
    protected int _exp;
    protected int _gold;

    protected Random _random = new Random();
    public bool IsAlive = true;

    protected Character(int maxHealth, int damage, int exp, int gold)
    {
        _maxHealth = maxHealth;
        _currentHealth = _maxHealth;
        _damage = damage;
        _exp = exp;
        _gold = gold;
    }
}