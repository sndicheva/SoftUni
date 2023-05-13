using WildFarm.Models.Interfaces;

namespace WildFarm.Factory.Interfaces;

public interface IAnimalFactory
{
    IAnimal CreateAnimal(string[] animalTokens);
}
