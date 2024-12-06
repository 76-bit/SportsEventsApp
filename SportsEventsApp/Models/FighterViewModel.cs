namespace SportsEventsApp.Models
{
    public class FighterViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string NickName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }
        public int Reach { get; set; }
        public string Category { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
