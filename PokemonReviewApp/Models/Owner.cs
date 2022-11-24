﻿using System.Diagnostics.Metrics;

namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
         public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
