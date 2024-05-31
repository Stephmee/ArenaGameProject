using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
    {
        public class Staff:Weapon
        {
            private const int BaseDamage = 200;
            private const int AbilityRounds = 2; 
            private int attackCount;

            public Staff():base("Staff")
            {
                attackCount = 0;
            }

            public void IncrementAttackCount()
            {
                attackCount++;
            }

            public bool IsUsingStaff()
            {
                return attackCount % AbilityRounds == 0;
            }

            public int GetStaffDamage()
            {
                return BaseDamage;
            }

        }
    }
