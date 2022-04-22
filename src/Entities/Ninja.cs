using rpg.src.Interfaces;

namespace rpg.src.Entities
{
  public class Ninja : Hero, IHero
  {

   static  int PONTOS_NINJA = 250;
   public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
    {
        this.Name =Name;
        this.Level=Level;
        this.HeroType=HeroType;
    }

    public string Attack(){
        return this.Name + " fez um ataque ninja";
    }

    public  int Pontuacao(){
        return  PONTOS_NINJA * 44;
    }
  }
}