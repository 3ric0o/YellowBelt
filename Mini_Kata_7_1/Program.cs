namespace Mini_Kata_7_1;

class Program
{
    static void Main(string[] args)
    { 
        var arin = new Player("Arin", 100, 1,50, 20);
        var orc = new Enemy("Orc", 50, 10);
        
        while (orc.IsAlive())
        {
            arin.Attack(arin.Damage, orc.Type);
            orc.TakeDamage(arin.Damage);
            
        }
        arin.GainExperience(orc.ExpGiven);
        Console.WriteLine($"{arin.Name} have {arin.Exp} experience.");
    }
}