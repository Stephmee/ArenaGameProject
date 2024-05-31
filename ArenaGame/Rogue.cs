using System;

namespace ArenaGame
{
    public class Rogue : Hero
    {
        private const int TripleDamageMagicLastDigit = 5;
        private const int HealEachNthRound = 3;
        private const int DaggerAttackFrequency = 3;
        private int attackCount;
        public bool isUsingWeapon = false;
        private Dagger dagger;

        public Rogue() : base("Robin Hood", 450, 125, new Dagger())
        {
            attackCount = 0;
            dagger = new Dagger();
        }

        public override int Attack()
        {
            attackCount++;
            IsUsingWeapon = false;
            int attack;
            if (attackCount % DaggerAttackFrequency == 0)
            {
                IsUsingWeapon = true;
                attack = dagger.Attack();
                dagger.HealRogue(this);
            }
            else
            {
                attack = base.Attack();
            }

            if (attack % 25 == TripleDamageMagicLastDigit)
            {
                attack *= 3;
            }

            if (attackCount % HealEachNthRound == 0 && ThrowDice(25))
            {
                Heal(StartingHealth * 50 / 100);
            }

            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(30)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
