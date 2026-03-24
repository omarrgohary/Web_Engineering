using Web_Eng.DTOs.Instructor;

namespace Web_Eng.Services.Interfaces
{
    public interface IInstructorService
    {
        Task<List<InstructorReadDto>> GetAllAsync();
        Task<InstructorReadDto?> GetByIdAsync(int id);
        Task<InstructorReadDto> CreateAsync(InstructorCreateDto dto);
        Task<bool> UpdateAsync(int id, InstructorUpdateDto dto);
        Task<bool> DeleteAsync(int id);
    }
}