using zadanie.Models;

namespace zadanie.Services;

public interface IAnimalsService
{
    
    

    IEnumerable<Animal> GetAnimals();
    int CreateAnimal(Animal newAnimal);
    //

}