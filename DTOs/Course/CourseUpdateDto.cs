using System.ComponentModel.DataAnnotations;

namespace Web_Eng.DTOs.Course
{
    public class CourseUpdateDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(300)]
        public string? Description { get; set; }

        [Range(1, 6)]
        public int CreditHours { get; set; }

        [Required]
        public int InstructorId { get; set; }
    }
}