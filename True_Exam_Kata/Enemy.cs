namespace True_Exam_Kata;

    public class Enemy
    {
        public string _type;
        private int _health;
        public int Damage { get; private set; }
        private int _expGive;
        private int _goldGive;
    
        public bool IsAlive = true;
        private readonly Random _random = new Random();
        public Enemy(string type, int health, int damage, int expGive, int goldGive)
        {
            _type = type;
            _health = health;
            Damage = damage;
            _expGive = expGive;
            _goldGive = goldGive;
        }
        
        public int DealDamage(string? playerName)
        {
            int damage = DamageCalculator();
            return damage;
        }
        private int DamageCalculator()
        {
            return _random.Next(1, Damage+1);
        }
}