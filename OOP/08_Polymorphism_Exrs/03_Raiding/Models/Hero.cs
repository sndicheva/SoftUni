using Raiding.IO;
using Raiding.Models.Interfaces;
using System;
using System.Buffers;
using System.Text;

namespace Raiding.Models;

public abstract class Hero : IHero
{
    protected Hero(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public string Name { get; private set; }

    public int Power { get; private set; }

    public virtual string CastAbility()
    {
        return $"{this.GetType().Name} - {Name} ";
    }
}
