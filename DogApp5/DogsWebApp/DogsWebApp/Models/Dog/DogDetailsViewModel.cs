﻿namespace DogsWebApp.Models.Dog
{
    public class DogDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string BreedName { get; set; } = null!;
        public string? Picture { get; set; }
    }
}