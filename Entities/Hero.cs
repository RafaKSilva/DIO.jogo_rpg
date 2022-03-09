namespace DIO.jogo_rpg.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name { get; set; }
        public int Level { get; set; } 
        public string HeroType { get; set; }

        public override string ToString() 
        {
            return $"Name: {this.Name}\nLevel: {this.Level}\nType: {this.HeroType}";
        }

        public string Attack()
        {
            return $"{this.Name} atacou com uma espada";
        }
    }
}