using PokemonReviewApp.Models;
namespace PokemonReviewApp.Dto
{
    public class PokemonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
    }
}
