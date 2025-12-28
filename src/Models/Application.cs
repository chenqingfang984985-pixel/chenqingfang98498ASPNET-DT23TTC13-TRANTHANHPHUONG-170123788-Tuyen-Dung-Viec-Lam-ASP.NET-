using System.ComponentModel.DataAnnotations;

namespace TuyenDungViecLam.Models
{
    public class Application
    {
        public string Id { get; set; } = string.Empty;
        
        [Required]
        public string JobId { get; set; } = string.Empty;
        
        [Required]
        public string CandidateId { get; set; } = string.Empty;
        
        public DateTime AppliedDate { get; set; }
        
        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
        
        public string CoverLetter { get; set; } = string.Empty;
    }

    public enum ApplicationStatus
    {
        Pending,
        Accepted,
        Rejected
    }
}