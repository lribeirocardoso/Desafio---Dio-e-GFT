using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.SRC.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroClass, int MP, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.MP = MP;
            this.HP = HP;
        }

        public string Attack(int Shield)
        {
            if (Shield >= 5)
            {
                return this.Name + " lançou um ataque poderoso e gerou um escudo de " + Shield + "% do seu HP total.\n";
            }
            else
            {
                return this.Name + " atacou com sua espada.\n";
            }
        }
    }
}
