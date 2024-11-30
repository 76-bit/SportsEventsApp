using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SportsEventsApp.Data
{
    //a class that connects the user with their fights (those in their watchlist)
    [PrimaryKey(nameof(UserId), nameof(FightId))]
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
    }
}