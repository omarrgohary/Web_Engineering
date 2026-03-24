using Web_Eng.DTOs.Enrollment;

namespace Web_Eng.Services.Interfaces
{
    public interface IEnrollmentService
    {
        Task<List<EnrollmentReadDto>> GetAllAsync();
        Task<EnrollmentReadDto> CreateAsync(EnrollmentCreateDto dto);
        Task<bool> DeleteAsync(int studentId, int courseId);
    }
}