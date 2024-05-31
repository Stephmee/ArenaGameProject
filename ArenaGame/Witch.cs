using System;

namespace ArenaGame
    {
        public class Witch : Hero
        {
            private Staff staff;
        private bool isUsingWeapon=false;

            public Witch() : base("Maleficent", 400, 150,new Staff())
            {
                staff = new Staff();
                IsUsingWeapon = false;
            }

            public override int Attack()
            {
                staff.IncrementAttackCount();

                if (staff.IsUsingStaff())
                {
                    IsUsingWeapon = true;
                    return staff.GetStaffDamage();
                }

                return base.Attack();
            }

            public override void TakeDamage(int incomingDamage)
            {
                if (IsUsingWeapon)
                {
                    incomingDamage = 0;
                    IsUsingWeapon = false; 
                }
                base.TakeDamage(incomingDamage);
            }
        }
    }

