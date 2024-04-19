using System.ComponentModel.DataAnnotations;

namespace zadanie.Models;


/*public enum category
{
    pies,
    kot
}*/

public class Animal
{
    
    [Required]
    public int IdAnimal { get; set; }
    
    
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    
    [MaxLength(200)]
    public string Description { get; set; }
    
    
    
    [Required]
    [MaxLength(200)]
    //[EnumDataType(typeof(category))]
    //public category Category { get; set; }
    public string Category { get; set; }
    
    
    [Required]
    [MaxLength(200)]
    public string Area { get; set; }
        
}

