
namespace YellowBelt;

class Program
{
    static string player = "Player";
    static void Main(string[] args)
    {
        Attack(15);
        Heal(10);
    }
    static void Attack(int damage)
    {
        Console.WriteLine($"{player} dealt {damage} damage!");
    }

    static void Heal(int healAmount)
    {
        Console.WriteLine($"{player} healed {healAmount} health!");
    }
}