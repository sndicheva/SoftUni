using WildFarm.Models.Food;

namespace WildFarm.Models.Animals;

public class Tiger : Feline
{
    private const double TigerWeightIncrease = 1;
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
    }

    protected override double WeightIncreace
        => TigerWeightIncrease;

    public override IReadOnlyCollection<Type> PreferredFoods
        => new HashSet<Type>() { typeof(Meat) };

    public override string ProduceSound()
        => "ROAR!!!";
}
