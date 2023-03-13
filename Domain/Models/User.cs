using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class User
{
    
    public int Id { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Recepies> RecepiesList { get; set; }

    public User(int id, string name, string email, string password, List<Recepies> recepiesList)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        RecepiesList = recepiesList;
    }
}