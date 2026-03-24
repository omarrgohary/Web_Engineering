namespace Web_Eng.DTOs.Course
{
    public class CourseReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int CreditHours { get; set; }
        public string InstructorName { get; set; } = string.Empty;
    }
}