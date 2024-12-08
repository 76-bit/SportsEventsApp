using SportsEventsApp.Data;
using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Services.Interfaces;

namespace SportsEventsApp.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly SportEventsAppDbContext _context;

        public CategoryService(SportEventsAppDbContext context)
        {
            _context = context;
        }

        // Retrieve all categories
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        // Retrieve a single category by ID
        public async Task<Category?> GetCategoryByIdAsync(Guid categoryId)
        {
            return await _context.Categories
                .FirstOrDefaultAsync(c => c.Id == categoryId);
        }
    }
}
