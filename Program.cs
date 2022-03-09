using System;
using DIO.jogo_rpg.Entities;

namespace DIO.jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 2, "Knight");
            Wizard wizard = new Wizard("Jennice",23,"White Wizard");

            Console.WriteLine($"Nome: {hero.Name}");
            Console.WriteLine($"Level: {hero.Level}");
            Console.WriteLine($"Type: {hero.HeroType}");

            Console.WriteLine(wizard);

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack());
             Console.WriteLine(wizard.Attack(20));
        }
    }
}
