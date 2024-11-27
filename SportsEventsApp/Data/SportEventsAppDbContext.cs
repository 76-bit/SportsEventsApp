using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SportsEventsApp.Data
{
    public class SportEventsAppDbContext : IdentityDbContext
    {
        public SportEventsAppDbContext(DbContextOptions<SportEventsAppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Category>()
                .HasData(
                new Category { Id = Guid.NewGuid(), Name = "Strawweight", MinWeight = 106, MaxWeight = 115 },
                new Category { Id = Guid.NewGuid(), Name = "Flyweight ", MinWeight = 115, MaxWeight = 125 },
                new Category { Id = Guid.NewGuid(), Name = "Bantamweight  ", MinWeight = 125, MaxWeight = 135 },
                new Category { Id = Guid.NewGuid(), Name = "Featherweight  ", MinWeight = 135, MaxWeight = 145 },
                new Category { Id = Guid.NewGuid(), Name = "Lightweight ", MinWeight = 145, MaxWeight = 155 },
                new Category { Id = Guid.NewGuid(), Name = "Welterweight  ", MinWeight = 155, MaxWeight = 170 },
                new Category { Id = Guid.NewGuid(), Name = "Middleweight  ", MinWeight = 170, MaxWeight = 185 },
                new Category { Id = Guid.NewGuid(), Name = "Light heavyweight ", MinWeight = 185, MaxWeight = 205},
                new Category { Id = Guid.NewGuid(), Name = "Middleweight  ", MinWeight = 205, MaxWeight = 265 });
                
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<FighterFight> FightersFights { get; set; }
        public DbSet<UserFight> UsersFights { get; set; }

    }
}
