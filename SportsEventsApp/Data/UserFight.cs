using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SportsEventsApp.Data
{
    //a class that connects the user with their fights (those in their watchlist and favorites page)
    [PrimaryKey(nameof(UserId), nameof(FightId), nameof(ListType))]
    public class UserFight
    {
        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        public Guid FightId { get; set; }

        [ForeignKey(nameof(FightId))]
        public Fight Fight { get; set; } = null!;

        [Required]
        [Comment("Indicates whether the fight is in the user's Watchlist or Favorites")]
        public string ListType { get; set; } = null!; // E.g., "Watchlist" or "Favorites"
    }
}