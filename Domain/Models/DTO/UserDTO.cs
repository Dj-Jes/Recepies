namespace Domain.Models.DTO;

public class UserDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<RecipeDTO> Recipes { get; set; }
}