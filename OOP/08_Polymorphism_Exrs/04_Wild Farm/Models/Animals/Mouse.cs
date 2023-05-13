﻿using WildFarm.Models.Food;

namespace WildFarm.Models.Animals;

public class Mouse : Mammal
{
    private const double MouseWeightIncrease = 0.10;
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    protected override double WeightIncreace 
        => MouseWeightIncrease;

    public override IReadOnlyCollection<Type> PreferredFoods 
        => new HashSet<Type>() { typeof(Vegetable), typeof(Fruit) };

    public override string ProduceSound()
        => "Squeak";
    public override string ToString()
    => base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
}
