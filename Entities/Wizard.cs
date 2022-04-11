using System;
namespace jogoRpg.Entities
{
    public class Wizard : Hero
    {
        public Wizard()
        {
        }
        public Wizard(String Name, int Level, String HeroType, String HP, String MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " --> Atacou lançou a Magia!!!";
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 6 )
            {
                return this.Name + " --> Atacou lançou a Super Magia!!! Bonus -> " + Bonus;
            }
            else
            {
                return this.Name + " --> Atacou lançou a Magia!!! Bonus -> " + Bonus;
            }
            
        }
    }
}
