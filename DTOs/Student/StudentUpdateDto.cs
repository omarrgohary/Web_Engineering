using System.ComponentModel.DataAnnotations;

namespace Web_Eng.DTOs.Student
{
    public class StudentUpdateDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Range(16, 100)]
        public int Age { get; set; }
    }
}