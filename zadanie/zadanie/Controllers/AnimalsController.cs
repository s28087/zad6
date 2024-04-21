using System.Collections;
using Microsoft.AspNetCore.Mvc;
using zadanie.Models;
using zadanie.Services;

namespace zadanie.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    
    private readonly IAnimalsService _animalsService;

    public AnimalsController(IAnimalsService animalsService)
    {
        _animalsService = animalsService;
    }
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animal = _animalsService.GetAnimals();
        return Ok(animal);
    }
    
    
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id,Animal animal)
    {
        var zm = _animalsService.UpdateAnimal(animal, id);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var zm = _animalsService.DeleteAnimal(id);
        return NoContent();
    }
    
    
}