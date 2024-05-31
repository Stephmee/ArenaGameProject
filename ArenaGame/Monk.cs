using System;

namespace ArenaGame
{
    public class Monk : Hero
    {
        private const int DoubleDamageEveryThirdAttack = 3;
        private int attackCount;
        private Nunchaku nunchaku;
        public bool isUsingWeapon=false;

        public Monk() : base("Ghandi", 700, 80,new Nunchaku())
        {
            attackCount = 0;
            nunchaku = new Nunchaku();
            isUsingWeapon = false;
        }

        public override int Attack()
        {
            attackCount++;
            IsUsingWeapon = false;
            if (attackCount % 2 == 0)
            {
                IsUsingWeapon = true;
                bool selfDamage = false;
                int damage = nunchaku.Attack(ref selfDamage);
                if (selfDamage == true)
                {
                    Console.WriteLine($"{Name} hits himself with Nunchaku for {damage} damage.");
                    TakeDamage(damage);
                    return 0;
                }
                else
                {
                    return damage;
                }
            }
            else
            {
                IsUsingWeapon = false;
                int attack = base.Attack();
                if (attackCount % DoubleDamageEveryThirdAttack == 0)
                {
                    attack *= 2;
                }
                return attack;
            }
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
        }
    }
}
