using System;

namespace ArenaGame
{
    public class Knight : Hero
    {
        const int BlockDamageChance = 10;
        private const int ExtraDamageChance = 5;
        private const int DoubleDamage = 3;
        private int attackCount;
        private Sword sword;
        public bool isUsingWeapon = false;

        public Knight() : base("Sir Lancelot", 550, 100,new Sword())
        {
            attackCount = 0;
            sword = new Sword();
        }

        public override void TakeDamage(int incomingDamage)
        {
            int damageReduceCoef = Random.Shared.Next(20, 61);
            incomingDamage = incomingDamage - ((incomingDamage * damageReduceCoef) / 100);
            if (ThrowDice(BlockDamageChance)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            attackCount++;
            IsUsingWeapon = false;
            int attack;
            if (attackCount % DoubleDamage == 0)
            {
                IsUsingWeapon = true;
                attack = sword.DoubleDamage(base.Attack());
                attackCount = 0;
            }
            else
            {
                attack = base.Attack();
                if (ThrowDice(ExtraDamageChance))
                {
                    attack = attack * 150 / 100;
                }
            }
            return attack;
        }
    }
}
