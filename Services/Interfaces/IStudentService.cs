using Web_Eng.DTOs.Student;

namespace Web_Eng.Services.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentReadDto>> GetAllAsync();
        Task<StudentReadDto?> GetByIdAsync(int id);
        Task<StudentReadDto> CreateAsync(StudentCreateDto dto);
        Task<bool> UpdateAsync(int id, StudentUpdateDto dto);
        Task<bool> DeleteAsync(int id);
    }
}