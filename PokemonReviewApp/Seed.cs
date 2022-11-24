using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
                {
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            BirthDate = new DateTime(2000, 2, 2),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Electric" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title = "Pikachu", Text = "Pikachu is the best pokemon",
                                    Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title = "Pikachu", Text = "Pikachu is the best a killing rocks",
                                    Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title = "Pikachu", Text = "Pikachu is the best bla bla bla",
                                    Reviewer = new Reviewer() { FirstName = "Tom", LastName = "Styles" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "London",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner() {
                        Pokemon = new Pokemon()
                        {
                            Name = "Squirtle",
                            BirthDate = new DateTime(2002, 3, 3),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Water" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title = "Squirtle", Text = "Squirtle is the best pokemon",
                                    Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title = "Squirtle", Text = "Squirtle is the best a killing rocks",
                                    Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title = "Squirtle", Text = "Squirtle is the best bla bla bla",
                                    Reviewer = new Reviewer() { FirstName = "Tom", LastName = "Styles" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Harry",
                            LastName = "Potter",
                            Country = new Country()
                            {
                                Name = "Saffron"
                            }
                        }
                    },
                    new PokemonOwner() {
                        Pokemon = new Pokemon()
                        {
                            Name = "Venasuar",
                            BirthDate = new DateTime(2003, 4, 4),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Leaf" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title = "Venasuar", Text = "Venasuar is the best pokemon",
                                    Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title = "Venasuar", Text = "Venasuar is the best a killing rocks",
                                    Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title = "Venasuar", Text = "Venasuar is the best bla bla bla",
                                    Reviewer = new Reviewer() { FirstName = "Tom", LastName = "Styles" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Ash",
                            LastName = "Ketchum",
                            Country = new Country()
                            {
                                Name = "Millet"
                            }
                        }
                    }
                };
                dataContext.PokemonOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();
            }
        }
    }
}

