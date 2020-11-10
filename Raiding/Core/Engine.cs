using Raiding.Models;
using Raiding.Models.Contracts;
using System;
using System.Collections.Generic;
using System.IO;


namespace Raiding
{
    public class Engine : IRun
    {
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            List<BaseHero> heroesRaid = new List<BaseHero>();
            BaseHero newHeroIsBorn;
            while(n!=counter)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type=="Druid")
                {
                    newHeroIsBorn = new Druid(name);
                    heroesRaid.Add(newHeroIsBorn);
                    counter++;
                }
                else if (type=="Paladin")
                {
                    newHeroIsBorn = new Paladin(name);
                    heroesRaid.Add(newHeroIsBorn);
                    counter++;
                }
                else if (type=="Rogue")
                {
                    newHeroIsBorn = new Rogue(name);
                    heroesRaid.Add(newHeroIsBorn);
                    counter++;
                }
                else if (type=="Warrior")
                {
                    newHeroIsBorn = new Warrior(name);
                    heroesRaid.Add(newHeroIsBorn);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }
            int bossStreight = int.Parse(Console.ReadLine());

            int heroesPower = 0;
            foreach (var hero in heroesRaid)
            {
                Console.WriteLine(hero.CastAbility());
                heroesPower += hero.Power;
            }
            if (heroesPower>=bossStreight)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
