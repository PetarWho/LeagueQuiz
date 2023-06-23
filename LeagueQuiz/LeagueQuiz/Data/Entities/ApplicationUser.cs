using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LeagueQuiz.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int HighestScore { get; set; } = 0;
    }
}
