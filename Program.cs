using System;
using DIO.jogo_rpg.Entities;

namespace DIO.jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 2, "Knight");
            Hero wizard =  new Hero("Jennice",23,"White Wizard");

            Console.WriteLine($"Nome: {hero.Name}");
            Console.WriteLine($"Level: {hero.Level}");
            Console.WriteLine($"Type: {hero.HeroType}");
        }
    }
}
