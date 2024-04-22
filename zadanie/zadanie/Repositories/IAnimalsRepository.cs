using zadanie.Models;

namespace zadanie.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    int CreateAnimal(Animal animal);
    //Animal GetAnimal(int idAnimal);
    int UpdateAnimal(Animal animal, int id);
    int DeleteAnimal(int idAnimal);
}