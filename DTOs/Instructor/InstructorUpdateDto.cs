using System.ComponentModel.DataAnnotations;

namespace Web_Eng.DTOs.Instructor
{
    public class InstructorUpdateDto
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string OfficeLocation { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Bio { get; set; }
    }
}