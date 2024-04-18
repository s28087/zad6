using System.Collections;
using Microsoft.AspNetCore.Mvc;
using zadanie.Models;
using zadanie.Services;

namespace zadanie.Controllers;


[Route("api/zwierzeta")]
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
    
}