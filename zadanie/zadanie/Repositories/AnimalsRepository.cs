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
        cmd.CommandText = "Select IdAnimal, Area, Description, Name, Category from Animals order by Name";

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
                Category = dr["Category"].ToString()
            };
            animals.Add(an);

            
            
        }

        //con.Close();
        
        return animals;

    }

    public int CreateAnimal(Animal animal)
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "INSERT INTO Animal(Area, Description, Name, Category) VALUES(@Area, @Description, @Name, @Category)";
        cmd.Parameters.AddWithValue("@Area", animal.Area);
        cmd.Parameters.AddWithValue("@Description", animal.Description);
        cmd.Parameters.AddWithValue("@Name", animal.Name);
        cmd.Parameters.AddWithValue("@Category", animal.Category);
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;
    }

    public int UpdateAnimal(Animal animal)
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "UPDATE Animal SET Arena=@Area, Description=@Description, Name=@Name, Category=@Category";
        cmd.Parameters.AddWithValue("@Area", animal.Area);
        cmd.Parameters.AddWithValue("@Description", animal.Description);
        cmd.Parameters.AddWithValue("@Name", animal.Name);
        cmd.Parameters.AddWithValue("@Category", animal.Category);
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;
    }

    public int DeleteAnimal(int id)
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "DELETE FROM Animal WHERE IdAnimal = @IdAnimal";
        cmd.Parameters.AddWithValue("@IdAnimal", id);
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;
    }

    /*public IEnumerable<Animal> GetAnimal(int idAnimal)
    {
        
    }*/
}