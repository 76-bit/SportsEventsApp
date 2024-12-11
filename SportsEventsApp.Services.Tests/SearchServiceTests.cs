using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using SportsEventsApp.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEventsApp.Tests.Services
{
    [TestFixture]
    public class Tests
    {
        private SportEventsAppDbContext _context;
        private SearchService _searchService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<SportEventsAppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new SportEventsAppDbContext(options);

            SeedDatabase();

            _searchService = new SearchService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        private void SeedDatabase()
        {
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
                CategoryId = Guid.NewGuid()
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
                CategoryId = Guid.NewGuid()
            };

            var fight1 = new Fight
            {
                Id = Guid.NewGuid(),
                Title = "Conor vs Khabib",
                Description = "A legendary UFC fight.",
                DateOfTheFight = DateTime.Now.AddDays(-10),
                PublisherId = "TestPublisher1",
                YouTubeUrl = "https://youtube.com/watch?v=test1",
                FighterFights = new List<FighterFight>
        {
            new FighterFight { Fighter = fighter1 },
            new FighterFight { Fighter = fighter2 }
        }
            };

            var fight2 = new Fight
            {
                Id = Guid.NewGuid(),
                Title = "Conor Returns",
                Description = "Conor McGregor makes his return.",
                DateOfTheFight = DateTime.Now.AddDays(10),
                PublisherId = "TestPublisher2",
                YouTubeUrl = "https://youtube.com/watch?v=test2",
                FighterFights = new List<FighterFight>
        {
            new FighterFight { Fighter = fighter1 }
        }
            };

            _context.Fighters.AddRange(fighter1, fighter2);
            _context.Fights.AddRange(fight1, fight2);
            _context.SaveChanges();
        }



        [Test]
        public async Task SearchFightsAsync_WhenQueryMatchesTitle_ReturnsCorrectResults()
        {
            var query = "Conor";

            var results = await _searchService.SearchFightsAsync(query);

            Assert.AreEqual(2, results.Count);
            Assert.IsTrue(results.Any(f => f.Title.Contains("Conor")));
        }

        [Test]
        public async Task SearchFightsAsync_WhenQueryMatchesDescription_ReturnsCorrectResults()
        {
            var query = "legendary";

            var results = await _searchService.SearchFightsAsync(query);

            Assert.AreEqual(1, results.Count);
            Assert.IsTrue(results.First().Description.Contains("legendary"));
        }

        [Test]
        public async Task SearchFightsAsync_WhenQueryMatchesFighterName_ReturnsCorrectResults()
        {
            var query = "Khabib";

            var results = await _searchService.SearchFightsAsync(query);

            Assert.AreEqual(1, results.Count);
            Assert.IsTrue(results.First().Title.Contains("Khabib"));
        }

        [Test]
        public async Task SearchFightsAsync_WhenQueryDoesNotMatchAnyResults_ReturnsEmptyList()
        {
            var query = "NonExistent";

            var results = await _searchService.SearchFightsAsync(query);

            Assert.AreEqual(0, results.Count);
        }
    }
}
