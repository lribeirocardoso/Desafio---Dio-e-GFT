using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.SRC.Entities
{
    public class WhiteWizard : Hero 
    {
        public WhiteWizard(string Name, int Level, string HeroClass, int MP, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.MP = MP;
            this.HP = HP;
        }

      
        public string Attack(int Heal)
        {
            if(Heal>= 5)
            {
                return this.Name + " lançou uma magia poderosa e curou " + Heal + "% do HP de todos os aliados.\n";
            }
            else
            {
                return this.Name + " lançou sua magia.\n";
            }      
        }
    }
}
