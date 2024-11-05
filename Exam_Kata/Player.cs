namespace Exam_Kata;

public class Player
{
    public string _name;
    private int _health;
    private int _level;
    private int _exp;
    private int _gold;

    public Player(string name, int health, int level, int exp, int gold)
    {
        _name = name;
        _health = health;
        _level = level;
        _exp = exp;
        _gold = gold;
    }
}