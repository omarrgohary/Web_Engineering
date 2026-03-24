using Web_Eng.DTOs.Course;

namespace Web_Eng.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<CourseReadDto>> GetAllAsync();
        Task<CourseReadDto?> GetByIdAsync(int id);
        Task<CourseReadDto> CreateAsync(CourseCreateDto dto);
        Task<bool> UpdateAsync(int id, CourseUpdateDto dto);
        Task<bool> DeleteAsync(int id);
    }
}