namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }
        
         
        public bool IsUsingWeapon { get; set; }

        Weapon Weapon { get; set; }
        

        public Hero(string name,int health,int strength, Weapon weapon)
        {
            Name = name;
            Health = health;
            StartingHealth = Health;
            Strength = strength;
            Weapon = weapon;
        }

        public virtual int Attack()
        {
            return (Strength * Random.Shared.Next(80, 121)) / 100;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            Health = Health - incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        public void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
