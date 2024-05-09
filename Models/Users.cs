using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MenaxhimProjekti.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public UserRole UserRole { get; set; }
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string UserEmail { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null !;
        public List<Projects> Projects { get; set; } = new List<Projects>();

    }
    public enum UserRole
    {
        Admin = 1,
        User = 2,
    }
}
