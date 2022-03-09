namespace DIO.jogo_rpg.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name,Level,HeroType)
        {

        }

        public override string Attack()
        {
            return $"{this.Name} lançou magia.";
        }

        public string Attack(int bonus)
        {
            return  $"{this.Name} lançou magia com bonus de ataque de {bonus}.";
        }
    }
}