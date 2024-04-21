using zadanie.Models;
using zadanie.Repositories;

namespace zadanie.Services;

public class AnimalsService : IAnimalsService
{
    /*private static List<Animal> _animals = new()
    {
        new Animal{IdAnimal = 1, Area = "a", Category = "Kot", Description = "aaa", Name = "pies"}
    };*/
    
    
    private readonly IAnimalsRepository _animalsRepository;
    
    public AnimalsService(IAnimalsRepository animalsRepository)
    {
         _animalsRepository = animalsRepository;
    }
    
    public IEnumerable<Animal> GetAnimals()
    {
        return _animalsRepository.GetAnimals();
    }

    public int CreateAnimal(Animal animal)
    {
        return _animalsRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal, int id)
    {
        return _animalsRepository.UpdateAnimal(animal, id);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalsRepository.DeleteAnimal(idAnimal);
    }
}