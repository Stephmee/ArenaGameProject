using System;
using System.Xml.Linq;

namespace ArenaGame
{
    public class Arena
    {
        private Hero heroA;
        private Hero heroB;
 

        public Arena(Hero a, Hero b)
        {
            heroA = a;
            heroB = b;
        }

        public Hero Battle()
        {
            Hero attacker, defender;
            if (Random.Shared.Next(2) == 0)
            {
                attacker = heroA;
                defender = heroB;
            }
            else
            {
                attacker = heroB;
                defender = heroA;
            }

            Console.WriteLine($"Battle between {attacker.Name} and {defender.Name} begins!");

            while (true)
            {
                int damage = attacker.Attack();
                if (damage != 0)
                {

                    if (attacker.IsUsingWeapon == true)
                    {
                        if (attacker.Name == "Sir Lancelot")
                        {
                            Console.WriteLine($"{attacker.Name} used Sword and dealt {damage} damage.");

                        }
                        else if (attacker.Name == "Ghandi")
                        {
                            Console.WriteLine($"{attacker.Name} used Nunchaku and dealt {damage} damage.");
                        }
                        else if (attacker.Name == "Robin Hood")
                        {
                            Console.WriteLine($"{attacker.Name} used Dagger dealing {damage} damage and healing for 75.");
                        }
                        else if (attacker.Name == "Maleficent")
                        {


                            Console.WriteLine($"{attacker.Name} used Staff and dealt {damage} damage.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{attacker.Name} attacks {defender.Name} for {damage} damage.");
                    }

                    int beforeTakeDamage = defender.Health;
                    defender.TakeDamage(damage);

                    if (defender.Health == beforeTakeDamage && defender.Name=="Maleficent")
                    {
                        Console.WriteLine($"{defender.Name} used her weapon and is invisible!");
                    }

                    //if(defender.IsUsingWeapon==true)
                    //{
                    //    if (defender.Name == "Maleficent")
                    //    {
                    //        Console.WriteLine($"{attacker.Name} used her weapon and is invisible!");
                    //    }
                    //}
                    if (defender.IsDead)
                    {
                        Console.WriteLine($"{defender.Name} has been defeated!");
                        return attacker;
                    }
                }
                Hero tmp = attacker;
                attacker = defender;
                defender = tmp;
            }
        }
    }
}
