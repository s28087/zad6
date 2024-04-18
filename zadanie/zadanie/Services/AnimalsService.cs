using zadanie.Models;

namespace zadanie.Services;

public class AnimalsService : IAnimalsService
{
    
    
    private static List<Animal> _animals = new()
    {
        new Animal{IdAnimal = 1, Area = "a", Category = category.kot, Description = "aaa", Name = "pies"}
    };

    
    public IEnumerable<Animal> GetAnimals()
    {
        // pobieramy cos z bazy danych i robimy cos z tymi danymi
        return _animals;
    }

    public int CreateAnimal(Animal newAnimal)
    {
        _animals.Add(newAnimal);
        return 1;
    }
}