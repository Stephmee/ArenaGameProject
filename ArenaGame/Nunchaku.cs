using System;

namespace ArenaGame
{
    public class Nunchaku:Weapon
    {
        private const int BaseDamage = 300;
        private const int AbilityChance = 20;

        private Random random;

        public Nunchaku():base("Nunchaku")
        {
            random = new Random();
        }

        public int Attack(ref bool selfDamage)
        {
            selfDamage = false;
            if (random.Next(1, 101) <= AbilityChance)
            {
                selfDamage = true;
            }
            return BaseDamage;
        }
    }
}
