using System;
using System.Collections.Generic;
using System.Linq;
using Raiding.Core.Interfaces;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;

namespace Raiding.Core;

public class Engine : IEngine
{
    private IReader reader;
    private IWriter writer;
    private IHeroFactory factory;

    private readonly ICollection<IHero> heroes;
    public Engine(IReader reader, IWriter writer, IHeroFactory factory)
    {
        this.reader = reader;
        this.writer = writer;
        this.factory = factory;

        this.heroes = new List<IHero>();
    }

    public void Run()
    {
        int count = int.Parse(reader.ReadLine());
        while (count > 0)
        {
            string name = reader.ReadLine();
            string type = reader.ReadLine();
            try
            {
                heroes.Add(factory.Create(type, name));
                count--;
            }
            catch (ArgumentException ex)
            {
                writer.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        int bossPower = int.Parse(reader.ReadLine());

        foreach (var hero in heroes)
        {
            writer.WriteLine(hero.CastAbility());
        }

        if (heroes.Sum(h=>h.Power) >= bossPower)
        {
            writer.WriteLine("Victory!");
        }
        else
        {
            writer.WriteLine("Defeat...");
        }
    }
}
