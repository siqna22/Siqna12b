﻿using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DogsApp.Infrastructure.Data.Entities;

namespace DogsApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Breed> Breeds { get; set; }
    }
}