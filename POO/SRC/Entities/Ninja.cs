using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.SRC.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroClass, int MP, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.MP = MP;
            this.HP = HP;
        }

        public string Attack(int Bonus)
        {
            if (Bonus>= 5)
            {
                return this.Name + " lançou um ataque poderoso e gerou um dano extra de " + Bonus + "% do HP atual do inimigo.\n";
            }
            else
            {
                return this.Name + " lançou sua kunai.\n";
            }
        }
    }
}
