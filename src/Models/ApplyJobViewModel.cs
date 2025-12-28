using System.ComponentModel.DataAnnotations;

namespace TuyenDungViecLam.Models
{
    public class ApplyJobViewModel
    {
        public string JobId { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;

        [Required(ErrorMessage = "Họ tên là bắt buộc")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email là bắt buộc")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Thư xin việc là bắt buộc")]
        public string CoverLetter { get; set; } = string.Empty;

        public IFormFile? Resume { get; set; }
    }
}