using System.ComponentModel.DataAnnotations;

namespace TuyenDungViecLam.Models
{
    public class Job
    {
        public string Id { get; set; } = string.Empty;
        
        [Required]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        public string Company { get; set; } = string.Empty;
        
        public string Logo { get; set; } = string.Empty;
        
        [Required]
        public string Location { get; set; } = string.Empty;
        
        [Required]
        public string Salary { get; set; } = string.Empty;
        
        [Required]
        public JobType Type { get; set; }
        
        [Required]
        public string Category { get; set; } = string.Empty;
        
        [Required]
        public string Description { get; set; } = string.Empty;
        
        public List<string> Requirements { get; set; } = new List<string>();
        
        public List<string> Benefits { get; set; } = new List<string>();
        
        public DateTime PostedDate { get; set; }
        
        [Required]
        public string EmployerId { get; set; } = string.Empty;
        
        public bool IsActive { get; set; } = true;
        
        public List<Application> Applications { get; set; } = new List<Application>();
    }

    public enum JobType
    {
        FullTime,
        PartTime,
        Contract,
        Remote
    }
}