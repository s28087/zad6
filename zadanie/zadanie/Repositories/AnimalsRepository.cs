using System.Data.SqlClient;
using zadanie.Models;

namespace zadanie.Repositories;

public class AnimalsRepository : IAnimalsRepository
{

    private IConfiguration _configuration;


    public AnimalsRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public IEnumerable<Animal> GetAnimals()
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        //SqlConnection con = new SqlConnection("Server=localhost;Database=APBD5_2;User Id; Password= ;");
        con.Open();

        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select * from Animals";

        //data reader
        var dr = cmd.ExecuteReader();
        var animals = new List<Animal>();

        while (dr.Read())
        {

            var an = new Animal
            {
                IdAnimal = (int)dr["IdAnimal"],
                Area = dr["Area"].ToString(),
                Description = dr["Description"].ToString(),
                Name = dr["Name"].ToString(),
                //Category = dr["Category"].ToString()
            };
            animals.Add(an);

            
            
        }




        //con.Close();
        
        return animals;

    }

    public IEnumerable<Animal> GetAnimal(int idAnimal)
    {
        
    }
}