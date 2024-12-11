using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using SportsEventsApp.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SportsEventsApp.Tests.Services
{

    [TestFixture]
    public class FightServiceTests
    {
        private SportEventsAppDbContext _context;
        private FightService _fightService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<SportEventsAppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new SportEventsAppDbContext(options);

            SeedDatabase();

            _fightService = new FightService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        private void SeedDatabase()
        {
            var adminUser = new IdentityUser
            {
                Id = "admin123",
                UserName = "admin@example.com"
            };

            var fighter1 = new Fighter
            {
                Id = Guid.NewGuid(),
                FirstName = "Conor",
                LastName = "McGregor",
                NickName = "The Notorious",
                DateOfBirth = new DateTime(1988, 7, 14),
                Height = 5.9,
                Reach = 74,
                Country = "Ireland",
                Category = new Category { Id = Guid.NewGuid(), Name = "Lightweight", MinWeight = 155, MaxWeight = 170 }
            };

            var fighter2 = new Fighter
            {
                Id = Guid.NewGuid(),
                FirstName = "Khabib",
                LastName = "Nurmagomedov",
                NickName = "The Eagle",
                DateOfBirth = new DateTime(1988, 9, 20),
                Height = 5.10,
                Reach = 70,
                Country = "Russia",
                Category = new Category { Id = Guid.NewGuid(), Name = "Lightweight", MinWeight = 155, MaxWeight = 170 }
            };

            var fight = new Fight
            {
                Id = Guid.NewGuid(),
                Title = "Conor vs Khabib",
                Description = "Legendary UFC fight.",
                DateOfTheFight = DateTime.Now.AddDays(-10),
                PublisherId = adminUser.Id,
                YouTubeUrl = "https://www.youtube.com/watch?v=12345",
                FighterFights = new List<FighterFight>
            {
                new FighterFight { Fighter = fighter1 },
                new FighterFight { Fighter = fighter2 }
            }
            };

            _context.Users.Add(adminUser);
            _context.Fighters.AddRange(fighter1, fighter2);
            _context.Fights.Add(fight);

            _context.SaveChanges();
        }

        [Test]
        public async Task GetAllFightsAsync_ReturnsNonDeletedFights()
        {
            var fight = _context.Fights.First();
            fight.IsDeleted = true;
            await _context.SaveChangesAsync();

            var results = await _fightService.GetAllFightsAsync();

            Assert.AreEqual(0, results.Count);
        }

        [Test]
        public async Task GetFightByIdAsync_ReturnsCorrectFight()
        {
            var fightId = _context.Fights.First().Id;

            var result = await _fightService.GetFightByIdAsync(fightId);

            Assert.NotNull(result);
            Assert.AreEqual(fightId, result.Id);
        }

        [Test]
        public async Task AddFightAsync_CreatesFightWithFighters()
        {
            var newFight = new Fight
            {
                Title = "New Fight",
                Description = "New Fight Description",
                DateOfTheFight = DateTime.Now.AddDays(10),
                PublisherId = "admin123"
            };

            var fighterIds = _context.Fighters.Select(f => f.Id).ToList();

            await _fightService.AddFightAsync(newFight, fighterIds);

            var addedFight = await _context.Fights.Include(f => f.FighterFights).FirstOrDefaultAsync(f => f.Id == newFight.Id);
            Assert.NotNull(addedFight);
            Assert.AreEqual(2, addedFight.FighterFights.Count);
        }

        [Test]
        public async Task EditFightAsync_UpdatesFightDetails()
        {
            var existingFight = _context.Fights.Include(f => f.FighterFights).First();
            var updatedFight = new Fight
            {
                Id = existingFight.Id,
                Title = "Updated Title",
                Description = "Updated Description",
                DateOfTheFight = existingFight.DateOfTheFight,
                ImageUrl = "/images/updated-image.jpg",
                YouTubeUrl = "https://www.youtube.com/watch?v=67890"
            };
            var newFighterIds = _context.Fighters.Take(1).Select(f => f.Id).ToList();

            await _fightService.EditFightAsync(updatedFight, newFighterIds);

            var fight = await _context.Fights.Include(f => f.FighterFights).FirstOrDefaultAsync(f => f.Id == existingFight.Id);
            Assert.AreEqual("Updated Title", fight.Title);
            Assert.AreEqual("Updated Description", fight.Description);
            Assert.AreEqual(1, fight.FighterFights.Count);
        }

        [Test]
        public async Task SoftDeleteFightAsync_MarksFightAsDeleted()
        {
            var fightId = _context.Fights.First().Id;

            await _fightService.SoftDeleteFightAsync(fightId);

            var fight = await _context.Fights.FirstOrDefaultAsync(f => f.Id == fightId);
            Assert.IsTrue(fight.IsDeleted);
        }
    }
}
