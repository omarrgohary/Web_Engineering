namespace Web_Eng.DTOs.Instructor
{
    public class InstructorReadDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string OfficeLocation { get; set; } = string.Empty;
        public string? Bio { get; set; }
    }
}