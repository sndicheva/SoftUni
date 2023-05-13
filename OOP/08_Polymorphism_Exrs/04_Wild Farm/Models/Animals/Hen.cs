using WildFarm.Models.Food;

namespace WildFarm.Models.Animals;

public class Hen : Bird
{
    public const double HenWeightIncrease = 0.35;

    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    public override IReadOnlyCollection<Type> PreferredFoods
        => new HashSet<Type>() { typeof(Meat), typeof(Vegetable), typeof(Fruit), typeof(Seeds) };

    protected override double WeightIncreace
        => HenWeightIncrease;

    public override string ProduceSound()
        => "Cluck";
}
