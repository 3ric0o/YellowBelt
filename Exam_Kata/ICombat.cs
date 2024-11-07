namespace Exam_Kata;

public interface ICombat
{

    public int DealDamage(string? playerName);

    public int DamageCalculator();

    public void TakeDamage(int damage);
    
}