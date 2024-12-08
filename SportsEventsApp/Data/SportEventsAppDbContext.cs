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

            // Predefined IDs for categories
            var strawweightId = Guid.NewGuid();
            var flyweightId = Guid.NewGuid();
            var bantamweightId = Guid.NewGuid();
            var featherweightId = Guid.NewGuid();
            var lightweightId = Guid.NewGuid();
            var welterweightId = Guid.NewGuid();
            var middleweightId = Guid.NewGuid();
            var lightHeavyweightId = Guid.NewGuid();
            var heavyweightId = Guid.NewGuid();

            // Seed categories
            builder.Entity<Category>().HasData(
                new Category { Id = strawweightId, Name = "Strawweight", MinWeight = 106, MaxWeight = 115 },
                new Category { Id = flyweightId, Name = "Flyweight", MinWeight = 115, MaxWeight = 125 },
                new Category { Id = bantamweightId, Name = "Bantamweight", MinWeight = 125, MaxWeight = 135 },
                new Category { Id = featherweightId, Name = "Featherweight", MinWeight = 135, MaxWeight = 145 },
                new Category { Id = lightweightId, Name = "Lightweight", MinWeight = 145, MaxWeight = 155 },
                new Category { Id = welterweightId, Name = "Welterweight", MinWeight = 155, MaxWeight = 170 },
                new Category { Id = middleweightId, Name = "Middleweight", MinWeight = 170, MaxWeight = 185 },
                new Category { Id = lightHeavyweightId, Name = "Light Heavyweight", MinWeight = 185, MaxWeight = 205 },
                new Category { Id = heavyweightId, Name = "Heavyweight", MinWeight = 205, MaxWeight = 265 }
            );

            // Seed admin user
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

            // Predefined IDs for fights
            var conorVsKhabibId = Guid.NewGuid();
            var adesanyaVsPereiraId = Guid.NewGuid();
            var silvaVsSonnenId = Guid.NewGuid();

            // Seed fights
            builder.Entity<Fight>().HasData(
                new Fight
                {
                    Id = conorVsKhabibId,
                    Title = "Conor McGregor vs Khabib Nurmagomedov",
                    Description = "A legendary UFC fight between two icons of the sport.",
                    DateOfTheFight = new DateTime(2018, 10, 6),
                    ImageUrl = "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg",
                    PublisherId = adminId,
                    YouTubeUrl = "https://www.youtube.com/watch?v=JuBBIJ7adjM",
                    IsDeleted = false
                },
                new Fight
                {
                    Id = adesanyaVsPereiraId,
                    Title = "Israel Adesanya vs Alex Pereira",
                    Description = "A thrilling bout between two fierce rivals.",
                    DateOfTheFight = new DateTime(2023, 4, 8),
                    ImageUrl = "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg",
                    PublisherId = adminId,
                    YouTubeUrl = "https://www.youtube.com/watch?v=yKdi_7cscd0",
                    IsDeleted = false
                },
                new Fight
                {
                    Id = silvaVsSonnenId,
                    Title = "Anderson Silva vs Chael Sonnen",
                    Description = "A classic middleweight bout filled with drama.",
                    DateOfTheFight = new DateTime(2012, 7, 7),
                    ImageUrl = "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg",
                    PublisherId = adminId,
                    YouTubeUrl = "https://www.youtube.com/watch?v=DpLaqnwFQEY",
                    IsDeleted = false
                }
            );

            // Predefined IDs for fighters
            var conorId = Guid.NewGuid();
            var khabibId = Guid.NewGuid();
            var adesanyaId = Guid.NewGuid();
            var pereiraId = Guid.NewGuid();
            var andersonId = Guid.NewGuid();
            var chaelId = Guid.NewGuid();

            // Seed fighters
            builder.Entity<Fighter>().HasData(
                new Fighter
                {
                    Id = conorId,
                    FirstName = "Conor",
                    LastName = "McGregor",
                    NickName = "The Notorious",
                    DateOfBirth = new DateTime(1988, 7, 14),
                    Height = 5.8,
                    Reach = 74,
                    Country = "Ireland",
                    CategoryId = lightweightId,
                    ImageUrl = "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG"
                },
                new Fighter
                {
                    Id = khabibId,
                    FirstName = "Khabib",
                    LastName = "Nurmagomedov",
                    NickName = "The Eagle",
                    DateOfBirth = new DateTime(1988, 9, 20),
                    Height = 5.10,
                    Reach = 70,
                    Country = "Russia",
                    CategoryId = lightweightId,
                    ImageUrl = "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png"
                },
                new Fighter
                {
                    Id = pereiraId,
                    FirstName = "Alex",
                    LastName = "Pereira",
                    NickName = "Poatan",
                    DateOfBirth = new DateTime(1987, 7, 7),
                    Height = 6.4,
                    Reach = 79,
                    Country = "Brazil",
                    CategoryId = middleweightId,
                    ImageUrl = "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj"
                },
                new Fighter
                {
                    Id = adesanyaId,
                    FirstName = "Israel",
                    LastName = "Adesanya",
                    NickName = "The Last Stylebender",
                    DateOfBirth = new DateTime(1989, 7, 22),
                    Height = 6.4,
                    Reach = 80,
                    Country = "Nigeria",
                    CategoryId = middleweightId,
                    ImageUrl = "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg"
                },
                new Fighter
                {
                    Id = andersonId,
                    FirstName = "Anderson",
                    LastName = "Silva",
                    NickName = "The Spider",
                    DateOfBirth= new DateTime(1975, 8, 14),
                    Height = 6.2,
                    Reach = 77,
                    Country = "Brazil",
                    CategoryId = middleweightId,
                    ImageUrl = "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640"
                },
                new Fighter
                {
                    Id = chaelId,
                    FirstName = "Chael",
                    LastName = "Sonnen",
                    NickName = "The American Gangster",
                    DateOfBirth= new DateTime(1977, 4, 3),
                    Height = 6.1,
                    Reach = 73,
                    Country = "U.S.",
                    CategoryId = middleweightId,
                    ImageUrl = "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG"
                }
            );

            // Seed FighterFight relationships
            builder.Entity<FighterFight>().HasData(
                new FighterFight
                {
                    FightId = conorVsKhabibId,
                    FighterId = conorId
                },
                new FighterFight
                {
                    FightId = conorVsKhabibId,
                    FighterId = khabibId
                },
                new FighterFight
                {
                    FightId = adesanyaVsPereiraId,
                    FighterId = adesanyaId
                },
                new FighterFight
                {
                    FightId = adesanyaVsPereiraId,
                    FighterId = pereiraId
                },
                new FighterFight
                {
                    FightId = silvaVsSonnenId,
                    FighterId = chaelId
                },
                new FighterFight
                {
                    FightId= silvaVsSonnenId,
                    FighterId = andersonId
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
