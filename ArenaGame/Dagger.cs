using System;

namespace ArenaGame
{
    public class Dagger:Weapon
    {
        private const int BaseDamage = 175;
        private const int HealAmount = 75;

        public Dagger():base("Dagger"){}

        public int Attack()
        {
            return BaseDamage;
        }

        public void HealRogue(Rogue rogue)
        {
            rogue.Heal(HealAmount);
        }
    }
}
