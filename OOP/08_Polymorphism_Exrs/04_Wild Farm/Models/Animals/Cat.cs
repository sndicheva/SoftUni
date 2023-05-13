using WildFarm.Models.Food;

namespace WildFarm.Models.Animals;

public class Cat : Feline
{
    private const double CatWeightIncrease = 0.30;
    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
    }

    public override IReadOnlyCollection<Type> PreferredFoods
        => new HashSet<Type>() { typeof(Vegetable), typeof(Meat) };
    protected override double WeightIncreace
        => CatWeightIncrease;


    public override string ProduceSound()
        => "Meow";
}
