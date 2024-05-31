using System;

namespace ArenaGame
{
    public class Sword:Weapon
    {
        public Sword() : base("Sword") { }

        public int DoubleDamage(int baseDamage)
        {
            return baseDamage * 2;
        }
    }
}
