using System.ComponentModel.DataAnnotations;
using static SportsEventsApp.Constants.ModelConstants;

namespace SportsEventsApp.Models
{
    public class FightViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(maxFightTitleLenght, MinimumLength = minFightTitleLenght)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(maxFightDescLenght, MinimumLength = minFightDescLenght)]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime DateOfTheFight { get; set; }

        public string? ImageUrl { get; set; }

        public string? YouTubeUrl { get; set; }

        public List<FighterViewModel>? Fighters { get; set; }
    }
}
