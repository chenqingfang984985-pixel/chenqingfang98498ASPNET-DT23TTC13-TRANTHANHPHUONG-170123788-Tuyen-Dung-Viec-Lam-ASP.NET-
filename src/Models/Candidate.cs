using System.ComponentModel.DataAnnotations;

namespace TuyenDungViecLam.Models
{
    public class phuongtran84
    {
        public string Id { get; set; } = string.Empty;
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        public string Phone { get; set; } = string.Empty;
        
        public string Avatar { get; set; } = string.Empty;
        
        public string Title { get; set; } = string.Empty;
        
        public string Experience { get; set; } = string.Empty;
        
        public List<string> Skills { get; set; } = new List<string>();
        
        public string Education { get; set; } = string.Empty;
        
        public string Resume { get; set; } = string.Empty;
    }
}