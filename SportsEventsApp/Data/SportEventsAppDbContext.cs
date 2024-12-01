using Microsoft.AspNetCore.Identity;
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

        // Adding seeding for categories and fights
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed categories
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
                new Category { Id = Guid.NewGuid(), Name = "Light heavyweight ", MinWeight = 185, MaxWeight = 205 },
                new Category { Id = Guid.NewGuid(), Name = "Middleweight  ", MinWeight = 205, MaxWeight = 265 });

            var adminId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<IdentityUser>();

            var adminUser = new IdentityUser
            {
                Id = adminId,
                UserName = "admin@mma.com",
                NormalizedUserName = "ADMIN@MMA.COM",
                Email = "admin@mma.com",
                NormalizedEmail = "ADMIN@MMA.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@12345")
            };

            builder.Entity<IdentityUser>().HasData(adminUser);

            // Seed fights with the admin's ID as PublisherId
            builder.Entity<Fight>().HasData(
                new Fight
                {
                    Id = Guid.NewGuid(),
                    Title = "Conor McGregor vs Khabib Nurmagomedov",
                    Description = "A legendary UFC fight between two icons of the sport.",
                    DateOfTheFight = new DateTime(2018, 10, 6),
                    ImageUrl = "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg",
                    PublisherId = adminId, // Link the admin to the fight
                    IsDeleted = false
                },
                new Fight
                {
                    Id = Guid.NewGuid(),
                    Title = "Israel Adesanya vs Alex Pereira",
                    Description = "A thrilling bout between two fierce rivals.",
                    DateOfTheFight = new DateTime(2023, 4, 8),
                    ImageUrl = "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg",
                    PublisherId = adminId, // Link the admin to the fight
                    IsDeleted = false
                },
                new Fight
                {
                    Id = Guid.NewGuid(),
                    Title = "Anderson Silva vs Chael Sonnen",
                    Description = "A classic middleweight bout filled with drama.",
                    DateOfTheFight = new DateTime(2012, 7, 7),
                    ImageUrl = "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg",
                    PublisherId = adminId,
                    IsDeleted = false
                },
                new Fight
                {
                    Id = Guid.NewGuid(),
                    Title = "Francis Ngannou vs Stipe Miocic",
                    Description = "A heavyweight clash for the championship title.",
                    DateOfTheFight = new DateTime(2021, 3, 27),
                    ImageUrl = "https://i.pinimg.com/736x/5e/69/ee/5e69ee1c4c9f20167f124387b2116c3a.jpg",
                    PublisherId = adminId,
                    IsDeleted = false
                },
                new Fight
                {
                    Id = Guid.NewGuid(),
                    Title = "Amanda Nunes vs Cris Cyborg",
                    Description = "A historic fight in women's MMA.",
                    DateOfTheFight = new DateTime(2018, 12, 29),
                    ImageUrl = "https://mmajunkie.usatoday.com/wp-content/uploads/sites/91/2018/11/cris-cyborg-amanda-nunes-ufc-230-press-conference-1.jpg?w=1000",
                    PublisherId = adminId,
                    IsDeleted = false
                }
            );
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Fight> Fights { get; set; }
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<FighterFight> FightersFights { get; set; }
        public DbSet<UserFight> UsersFights { get; set; }
    }
}
