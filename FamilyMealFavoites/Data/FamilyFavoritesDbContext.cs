using Microsoft.EntityFrameworkCore;
using FamilyMealFavoites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMealFavoites.Data
{
    public class FamilyFavoritesDbContext : DbContext
    {
        public FamilyFavoritesDbContext(DbContextOptions<FamilyFavoritesDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(
                u => new { u.AccountId });

        }
        public DbSet<Account> Account { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

    }
}
