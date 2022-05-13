using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.SRC.Entities
{
    public abstract class Hero
    {
        public Hero() { }

        public Hero(string Name, int Level, string HeroClass, int MP, int HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroClass = HeroClass;
            this.MP = MP;
            this.HP = HP;
        }

        public string Name;

        public int Level;

        public string HeroClass;

        public int MP;

        public int HP;

        public override string ToString()
        {
            return "Name: "+this.Name + "\nLevel: " + this.Level + "\nCLass: " + this.HeroClass + "\nMP: "+ this.MP + "\nHP: " + this.HP + "\n";
        }

        public virtual string Attack()
        {
            return this.Name + " ataque.";
        }
    }
}

