namespace SportsEventsApp.Models
{
    public class PaginatedListViewModel<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
