using System.ComponentModel.DataAnnotations;

namespace TuyenDungViecLam.Models
{
    public class Employer
    {
        public string Id { get; set; } = string.Empty;
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public string Logo { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;
        
        public string Website { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        public string Phone { get; set; } = string.Empty;
        
        public string Address { get; set; } = string.Empty;
        
        public string Industry { get; set; } = string.Empty;
        
        public string Size { get; set; } = string.Empty;
        
        public List<string> Jobs { get; set; } = new List<string>();
    }
}