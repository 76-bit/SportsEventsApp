using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using SportsEventsApp.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEventsApp.Services.Tests
{
    [TestFixture]
    public class FighterServiceTests
    {
        private SportEventsAppDbContext _context;
        private FighterService _fighterService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<SportEventsAppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new SportEventsAppDbContext(options);

            SeedDatabase();

            _fighterService = new FighterService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        private void SeedDatabase()
        {
            var category = new Category { Id = Guid.NewGuid(), Name = "Lightweight", MinWeight = 135, MaxWeight = 155 };

            var fighters = new List<Fighter>
            {
                new Fighter
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Conor",
                    LastName = "McGregor",
                    NickName = "The Notorious",
                    DateOfBirth = new DateTime(1988, 7, 14),
                    Height = 5.9,
                    Reach = 74,
                    Country = "Ireland",
                    CategoryId = category.Id,
                    Category = category
                },
                new Fighter
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Khabib",
                    LastName = "Nurmagomedov",
                    NickName = "The Eagle",
                    DateOfBirth = new DateTime(1988, 9, 20),
                    Height = 5.10,
                    Reach = 70,
                    Country = "Russia",
                    CategoryId = category.Id,
                    Category = category,
                    IsDeleted = true 
                }
            };

            _context.Categories.Add(category);
            _context.Fighters.AddRange(fighters);
            _context.SaveChanges();
        }

        [Test]
        public async Task GetFighterByIdAsync_WhenIdExistsAndNotDeleted_ReturnsFighter()
        {
            var existingFighter = _context.Fighters.First(f => !f.IsDeleted);

            var result = await _fighterService.GetFighterByIdAsync(existingFighter.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(existingFighter.FirstName, result.FirstName);
        }

        [Test]
        public async Task GetFighterByIdAsync_WhenIdExistsButDeleted_ReturnsNull()
        {
            var deletedFighter = _context.Fighters.First(f => f.IsDeleted);

            var result = await _fighterService.GetFighterByIdAsync(deletedFighter.Id);

            Assert.IsNull(result);
        }

        [Test]
        public async Task GetAllFightersAsync_ExcludesDeletedByDefault()
        {
            var result = await _fighterService.GetAllFightersAsync();

            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.All(f => !f.IsDeleted));
        }

        [Test]
        public async Task GetAllFightersAsync_IncludesDeletedWhenSpecified()
        {
            var result = await _fighterService.GetAllFightersAsync(includeDeleted: true);

            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public async Task AddFighterAsync_AddsNewFighter()
        {
            var category = _context.Categories.First();
            var newFighter = new Fighter
            {
                Id = Guid.NewGuid(),
                FirstName = "Max",
                LastName = "Holloway",
                NickName = "Blessed",
                DateOfBirth = new DateTime(1991, 12, 4),
                Height = 5.11,
                Reach = 69,
                Country = "USA",
                CategoryId = category.Id,
                Category = category
            };

            await _fighterService.AddFighterAsync(newFighter);
            var result = _context.Fighters.FirstOrDefault(f => f.Id == newFighter.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(newFighter.FirstName, result.FirstName);
        }

        [Test]
        public async Task EditFighterAsync_UpdatesFighterDetails()
        {
            var existingFighter = _context.Fighters.First(f => !f.IsDeleted);
            existingFighter.FirstName = "UpdatedFirstName";

            await _fighterService.EditFighterAsync(existingFighter);
            var updatedFighter = _context.Fighters.First(f => f.Id == existingFighter.Id);

            Assert.AreEqual("UpdatedFirstName", updatedFighter.FirstName);
        }

        [Test]
        public void EditFighterAsync_WhenFighterDoesNotExist_ThrowsInvalidOperationException()
        {
            var nonExistentFighter = new Fighter { Id = Guid.NewGuid() };

            Assert.ThrowsAsync<InvalidOperationException>(async () =>
                await _fighterService.EditFighterAsync(nonExistentFighter));
        }

        [Test]
        public async Task SoftDeleteFighterAsync_MarksFighterAsDeleted()
        {
            var fighter = _context.Fighters.First(f => !f.IsDeleted);

            await _fighterService.SoftDeleteFighterAsync(fighter.Id);
            var result = _context.Fighters.First(f => f.Id == fighter.Id);

            Assert.IsTrue(result.IsDeleted);
        }

        [Test]
        public void SoftDeleteFighterAsync_WhenFighterDoesNotExist_ThrowsInvalidOperationException()
        {
            var nonExistentId = Guid.NewGuid();

            Assert.ThrowsAsync<InvalidOperationException>(async () =>
                await _fighterService.SoftDeleteFighterAsync(nonExistentId));
        }
    }
}
