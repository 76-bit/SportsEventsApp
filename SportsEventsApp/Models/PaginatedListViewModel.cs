namespace SportsEventsApp.Models
{
    public class PaginatedListViewModel<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; } = 4; // Default page size

        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
        public int CurrentItemCount => Items?.Count ?? 0;
    }
}
