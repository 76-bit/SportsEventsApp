using System.ComponentModel.DataAnnotations;
using static SportsEventsApp.Constants.ModelConstants;

namespace SportsEventsApp.Models
{
    public class FighterViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(maxFighterViewModelNameLength, MinimumLength = minFighterViewModelNameLength, ErrorMessage = "First name must be between 2 and 50 characters.")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(maxFighterViewModelNameLength, MinimumLength = minFighterViewModelNameLength, ErrorMessage = "Last name must be between 2 and 50 characters.")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(maxFighterViewModelNameLength, MinimumLength = minFighterViewModelNameLength, ErrorMessage = $"Nickname must be between 2 and 50 characters.")]
        public string NickName { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(4, 7, ErrorMessage = "Height must be between 4 feet and 7 feet")]
        public double Height { get; set; }

        [Required]
        [Range(40, 90, ErrorMessage = "Reach must be between 40 inhes and 90 inches")]
        public int Reach { get; set; }

        [Required]
        public string Country { get; set; } = null!;

        [Required(ErrorMessage = "Please select a category.")]
        public Guid CategoryId { get; set; } // Category selection for forms

        public string? Category { get; set; } // Display name of category

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = "/images/default-fighter.jpg"; // Default image
    }
}
