using System.ComponentModel.DataAnnotations;

namespace LeagueQuiz.Data.Entities
{
    public class Ability
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageURL { get; set; } = null!;

        [Required]
        public bool IsPassive { get; set; }
    }
}
