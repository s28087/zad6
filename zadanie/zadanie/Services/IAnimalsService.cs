using zadanie.Models;

namespace zadanie.Services;

public interface IAnimalsService
{
    
    
    IEnumerable<Animal> GetAnimals();
    int CreateAnimal(Animal animal);
    //Animal? GetAnimal(int idAnimal);
    int UpdateAnimal(Animal animal, int id);
    int DeleteAnimal(int idAnimal);

}