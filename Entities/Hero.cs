using System;
namespace jogoRpg.Entities
{
    public class Hero : IHero
    {
        public Hero()
        {

        }
        public Hero(String Name, int Level, String HeroType, String HP, String MP)
        {
            this.Name     = Name;
            this.Level    = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public String Name { get; set; }

        public int Level { get; set; }

        public String HeroType { get; set; }

        public String HP { get; set; }

        public String MP { get; set; }

        public override String ToString() {

            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HP + " " + this.MP;

        }

        public virtual string Attack() {

            return this.Name + " --> Atacou com sua espada!!!";

        }

        public virtual string Attack(int Bonus)
        {
            if (Bonus > 10)
            {
                return this.Name + " --> Atacou com sua espada Excalibur!!! Bonus -> " + Bonus;
            }
            else
            {
                return this.Name + " --> Atacou com sua espada!!! Bonus -> " + Bonus;
            }
            
        }
    }
}
