namespace Domain.Models.DTO;

public class RecipeDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<IngredientDTO> Ingredients { get; set; }
    public string Instructions { get; set; }
}