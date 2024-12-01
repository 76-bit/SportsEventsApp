namespace SportsEventsApp.Models
{
    public class FightViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOfTheFight { get; set; }
        public string? ImageUrl { get; set; }
    }
}
