using rpg.src.Interfaces;

namespace rpg.src.Entities
{
    public class Wizard : Hero, IHero
    {
        static  int PONTOS_WIZARD = 120;
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name =Name;
            this.Level=Level;
            this.HeroType=HeroType;
        }
        
        public string Attack(){
            return this.Name + " lançou uma magia";
        }

        public  int Pontuacao(){
            return PONTOS_WIZARD * 44;
        }
    }
}