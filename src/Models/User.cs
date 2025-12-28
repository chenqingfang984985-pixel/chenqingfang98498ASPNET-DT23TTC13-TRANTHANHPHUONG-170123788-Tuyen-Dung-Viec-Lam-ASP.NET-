using System.ComponentModel.DataAnnotations;

namespace TuyenDungViecLam.Models
{
    public class User
    {
        public string Id { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        public UserRole Role { get; set; }
        
        public string ProfileId { get; set; } = string.Empty;
    }

    public enum UserRole
    {
        phuongtran84,
        Employer,
        Admin
    }
}