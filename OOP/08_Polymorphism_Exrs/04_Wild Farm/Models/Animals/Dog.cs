using WildFarm.Models.Food;

namespace WildFarm.Models.Animals;

public class Dog : Mammal
{
    private const double DogWeightIncrease = 0.40;
    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    protected override double WeightIncreace
        => DogWeightIncrease;

    public override IReadOnlyCollection<Type> PreferredFoods
        => new HashSet<Type>() { typeof(Meat) };

    public override string ProduceSound()
        => "Woof!";

    public override string ToString()
        => base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
}
