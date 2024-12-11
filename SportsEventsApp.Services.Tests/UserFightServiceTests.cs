using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using SportsEventsApp.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SportsEventsApp.Services.Tests
{
    [TestFixture]
    public class UserFightServiceTests
    {
        private SportEventsAppDbContext _context;
        private UserFightService _userFightService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<SportEventsAppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new SportEventsAppDbContext(options);

            SeedDatabase();

            _userFightService = new UserFightService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        private void SeedDatabase()
        {
            var user = new IdentityUser { Id = "test-user", UserName = "test@example.com" };

            var fight1 = new Fight
            {
                Id = Guid.NewGuid(),
                Title = "Fight 1",
                Description = "Description 1",
                DateOfTheFight = DateTime.Now.AddDays(-10),
                PublisherId = user.Id,
                YouTubeUrl = "https://www.youtube.com/watch?v=dummyvideo1"
            };

            var fight2 = new Fight
            {
                Id = Guid.NewGuid(),
                Title = "Fight 2",
                Description = "Description 2",
                DateOfTheFight = DateTime.Now.AddDays(10),
                PublisherId = user.Id,
                YouTubeUrl = "https://www.youtube.com/watch?v=dummyvideo2"
            };

            _context.Users.Add(user);
            _context.Fights.AddRange(fight1, fight2);

            var userFight = new UserFight
            {
                UserId = user.Id,
                FightId = fight1.Id,
                ListType = "Favorites"
            };

            _context.UsersFights.Add(userFight);
            _context.SaveChanges();
        }

        [Test]
        public async Task AddToListAsync_WhenNotInList_AddsFightToList()
        {
            var userId = "test-user";
            var newFightId = _context.Fights.First(f => f.Title == "Fight 2").Id;

            await _userFightService.AddToListAsync(userId, newFightId, "Favorites");
            var result = _context.UsersFights.FirstOrDefault(uf => uf.UserId == userId && uf.FightId == newFightId);

            Assert.IsNotNull(result);
            Assert.AreEqual("Favorites", result.ListType);
        }

        [Test]
        public async Task AddToListAsync_WhenAlreadyInList_DoesNotAddDuplicate()
        {
            var userId = "test-user";
            var existingFightId = _context.Fights.First(f => f.Title == "Fight 1").Id;

            await _userFightService.AddToListAsync(userId, existingFightId, "Favorites");
            var resultCount = _context.UsersFights.Count(uf => uf.UserId == userId && uf.FightId == existingFightId);

            Assert.AreEqual(1, resultCount);
        }

        [Test]
        public async Task RemoveFromListAsync_WhenInList_RemovesFightFromList()
        {
            var userId = "test-user";
            var existingFightId = _context.Fights.First(f => f.Title == "Fight 1").Id;

            await _userFightService.RemoveFromListAsync(userId, existingFightId, "Favorites");
            var result = _context.UsersFights.FirstOrDefault(uf => uf.UserId == userId && uf.FightId == existingFightId);

            Assert.IsNull(result);
        }

        [Test]
        public async Task RemoveFromListAsync_WhenNotInList_DoesNotThrow()
        {
            var userId = "test-user";
            var nonExistentFightId = Guid.NewGuid();

            Assert.DoesNotThrowAsync(async () =>
                await _userFightService.RemoveFromListAsync(userId, nonExistentFightId, "Favorites"));
        }

        [Test]
        public async Task GetListAsync_ReturnsCorrectFightsForUserAndListType()
        {
            var userId = "test-user";

            var result = await _userFightService.GetListAsync(userId, "Favorites");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Fight 1", result.First().Title);
        }
    }
}
