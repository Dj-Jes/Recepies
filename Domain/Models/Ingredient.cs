using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Ingredient
{   
    public string Name { get; set; }
    [Required]
    public decimal Amount { get; set; }
    [Required]
    public string Unit { get; set; }

    public Ingredient(string name, decimal amount, string unit)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }
}