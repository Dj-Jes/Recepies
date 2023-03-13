using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Domain.Models;

public class Recepies
{
    [Key]
    public int Id { get; set;}
    public string Title { get; }
    [Required, MaxLength(20)]
    public List<Ingredient> Ingredients { get; set; }
    [Required]
    public string Instructions { get; set; }
    [Required]
    
    
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }


    public Recepies(int id, string title, List<Ingredient> ingredients, string instructions, int userId, User user)
    {
        Id = id;
        Title = title;
        Ingredients = ingredients;
        Instructions = instructions;
        UserId = userId;
        User = user;
    }
}