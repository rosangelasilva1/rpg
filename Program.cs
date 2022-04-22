using System;
using rpg.src.Entities;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Wizard wizard = new Wizard("Jennica", 23, "white wizard");
            Ninja ninja = new Ninja("Wedge", 40, "Ninja");
            
            
            Console.WriteLine(wizard.Attack());
            Console.WriteLine($"Pontuação: {wizard.Pontuacao()}");
            Console.WriteLine("============================");
            Console.WriteLine(ninja.Attack());
            Console.WriteLine($"Pontuação: {ninja.Pontuacao()}");
        }
    }
}
