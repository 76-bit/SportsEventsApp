using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsEventsApp.Data
{
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