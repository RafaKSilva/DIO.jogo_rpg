using System;
using DIO.jogo_rpg.Entities;

namespace DIO.jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus();
            hero.Name =  "Arus";
            hero.Level = 2;
            hero.HeroType = "Knight";

            Console.WriteLine($"Nome: {hero.Name}");
            Console.WriteLine($"Level: {hero.Level}");
            Console.WriteLine($"Type: {hero.HeroType}");
        }
    }
}
