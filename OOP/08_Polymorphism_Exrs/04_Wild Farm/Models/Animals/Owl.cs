using WildFarm.Models.Food;

namespace WildFarm.Models.Animals;

public class Owl : Bird
{
    public const double OwlWeightIncrease = 0.25;

    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    public override IReadOnlyCollection<Type> PreferredFoods
        => new HashSet<Type>() { typeof(Meat) };

    protected override double WeightIncreace
        => OwlWeightIncrease;

    public override string ProduceSound()
        => "Hoot Hoot";
}
