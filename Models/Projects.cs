using System.ComponentModel.DataAnnotations;

namespace MenaxhimProjekti.Models
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public StatusEnum Status { get; set; }
        public int Duration { get; set; } 
        public List<Users> Users { get; set; } = new List<Users>();
    }
    public enum StatusEnum 
    { 
        Initial = 1,
        Ongoing = 2,
        Completed = 3
    }
}
