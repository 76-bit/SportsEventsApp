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
    public class CategoryServiceTests
    {
        private SportEventsAppDbContext _context;
        private CategoryService _categoryService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<SportEventsAppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new SportEventsAppDbContext(options);

            SeedDatabase();

            _categoryService = new CategoryService(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        private void SeedDatabase()
        {
            var categories = new List<Category>
            {
                new Category { Id = Guid.NewGuid(), Name = "Lightweight", MinWeight = 135, MaxWeight = 155 },
                new Category { Id = Guid.NewGuid(), Name = "Middleweight", MinWeight = 155, MaxWeight = 185 },
                new Category { Id = Guid.NewGuid(), Name = "Heavyweight", MinWeight = 205, MaxWeight = 265 }
            };

            _context.Categories.AddRange(categories);
            _context.SaveChanges();
        }

        [Test]
        public async Task GetAllCategoriesAsync_ReturnsAllCategories()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();

            Assert.AreEqual(3, categories.Count);
            Assert.IsTrue(categories.Any(c => c.Name == "Lightweight"));
            Assert.IsTrue(categories.Any(c => c.Name == "Middleweight"));
            Assert.IsTrue(categories.Any(c => c.Name == "Heavyweight"));
        }

        [Test]
        public async Task GetCategoryByIdAsync_WhenIdExists_ReturnsCorrectCategory()
        {
            var targetCategory = _context.Categories.First();

            var category = await _categoryService.GetCategoryByIdAsync(targetCategory.Id);

            Assert.IsNotNull(category);
            Assert.AreEqual(targetCategory.Name, category.Name);
        }

        [Test]
        public async Task GetCategoryByIdAsync_WhenIdDoesNotExist_ReturnsNull()
        {
            var invalidId = Guid.NewGuid();

            var category = await _categoryService.GetCategoryByIdAsync(invalidId);

            Assert.IsNull(category);
        }
    }
}
