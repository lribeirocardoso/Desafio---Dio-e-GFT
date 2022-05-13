using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.SRC.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroClass, int MP, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.MP = MP;
            this.HP = HP;
        }

        public string Attack(int Damage)
        {
            if (Damage >= 5)
            {
                return this.Name + " lançou uma magia poderosa e gerou um dano extra de " + Damage * this.Level + " no inimigo.\n";
            }
            else
            {
                return this.Name + " lançou sua magia.\n";
            }
        }
    }
}
