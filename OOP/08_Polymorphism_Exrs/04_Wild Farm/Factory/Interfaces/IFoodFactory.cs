using WildFarm.Models.Interfaces;

namespace WildFarm.Factory.Interfaces;

public interface IFoodFactory
{
    IFood CreateFood(string type, int quantity);
}
