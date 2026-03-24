using System.ComponentModel.DataAnnotations;

namespace Web_Eng.DTOs.Enrollment
{
    public class EnrollmentCreateDto
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }
    }
}