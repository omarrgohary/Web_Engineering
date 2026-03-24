using System.ComponentModel.DataAnnotations;
using Web_Eng.Models;

namespace Web_Eng.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(300)]
        public string? Description { get; set; }

        public int CreditHours { get; set; }

        public int InstructorId { get; set; }
        public User Instructor { get; set; } = null!;

        public List<Enrollment> Enrollments { get; set; } = new();
    }
}