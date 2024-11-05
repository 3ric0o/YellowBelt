namespace Kata_10;

class Program
{
    static void Main(string[] args)
    {
        var arin = new Player("Arin", 100, 1, 20);
        var goblin = new Enemy("Goblin", 50, 20);
        var npc = new Npc("NPC");
        var merchant = new Merchant("Merchant");
        
        
        arin.Attack(goblin.Type, arin.Damage);
        goblin.TakeDamage(arin.Damage);
        npc.Dialogue();
        merchant.Trade();
    }
}