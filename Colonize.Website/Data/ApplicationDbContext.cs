using Colonize.Website.Entities;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Colonize.Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Voyage> Voyage { get; set; }
        public DbSet<Ship> Ship { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var ships = new List<Ship>
            {
                   new Ship(1, "Shoes", "Lorem ipsum dolor", 200,
                    new Uri("https://via.placeholder.com/480x360.png?text=Jacket" , UriKind.Absolute)),
                new Ship(2, "Mars Explorer", "Lorem ipsum dolor", 2800,
                    new Uri(" https://via.placeholder.com/480x360.png?text=Jacket" , UriKind.Absolute))
            };

            ships.ForEach(x => modelBuilder.Entity<Ship>().HasData(x));

            var destinations = new List<Destination>
            {
                new Destination(1, "Adidas", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Jacket" , UriKind.Absolute)),
                new Destination(2, "Nike", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Jacket" , UriKind.Absolute))
            };

            destinations.ForEach(x => modelBuilder.Entity<Destination>().HasData(x));

            var moonshot = ships.Find(x => x.Name == "Shoes");
            var marsExplorer = ships.Find(x => x.Name == "Mars Explorer");

            var shoe = destinations.Find(x => x.Name == "Adidas");
            var hoodie = destinations.Find(x => x.Name == "Nike");

            var voyages = new List<Voyage>
            {
                new Voyage(1, shoe.Id, moonshot.Id, new DateTime(2024, 6, 4), new DateTime(2024, 6, 8)),
                new Voyage(2, hoodie.Id, marsExplorer.Id, new DateTime(2028, 12, 1), new DateTime(2029, 2, 1)),
            };

            voyages.ForEach(x => modelBuilder.Entity<Voyage>().HasData(x));
        }
    }
}













