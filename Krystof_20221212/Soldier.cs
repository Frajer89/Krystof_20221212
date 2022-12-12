using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krystof_20221212
{
    public class Soldier
    {
        private int level;

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int HP { get; set; }
        public int Level { get => level; }
        public int Shield { get; set; }

        public Soldier()
        {
            Jmeno = "";
            Prijmeni = "";
            level = 1;
            HP = 100;
            Shield = 100;
        }
        public void Attack()
        {
            Shield -= 20;
            if (Shield <= 0)
            {
                Shield = 0;
                HP -= 20;
            }

        }

        public void Heal()
        {
            Shield += 10;
            if (Shield > 200)
            {
                Shield = 200;
            }
        }
        public void SuperAttack()
        {
            Shield -= 40;
            if (Shield <= 0)
            {
                Shield = 0;
                HP -= 40;
            }
        }
        public void SuperHeal()
        {
            Shield += 30;
            if (Shield > 200)
            {
                Shield = 200;
            }
        }
    }
}

