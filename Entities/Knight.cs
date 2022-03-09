namespace DIO.jogo_rpg.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name,Level,HeroType)
        {

        }

        public override string Attack()
        {
            return $"{this.Name} atacou com a sua espada";
        }
    }
}