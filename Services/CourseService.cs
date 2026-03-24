using Microsoft.EntityFrameworkCore;
using Web_Eng.Data;
using Web_Eng.DTOs.Course;
using Web_Eng.Models;
using Web_Eng.Services.Interfaces;

namespace Web_Eng.Services
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CourseReadDto>> GetAllAsync()
        {
            return await _context.Courses
                .AsNoTracking()
                .Include(c => c.Instructor)
                .Select(c => new CourseReadDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    CreditHours = c.CreditHours,
                    InstructorName = c.Instructor.FullName
                })
                .ToListAsync();
        }

        public async Task<CourseReadDto?> GetByIdAsync(int id)
        {
            return await _context.Courses
                .AsNoTracking()
                .Include(c => c.Instructor)
                .Where(c => c.Id == id)
                .Select(c => new CourseReadDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    CreditHours = c.CreditHours,
                    InstructorName = c.Instructor.FullName
                })
                .FirstOrDefaultAsync();
        }

        public async Task<CourseReadDto> CreateAsync(CourseCreateDto dto)
        {
            var course = new Course
            {
                Title = dto.Title,
                Description = dto.Description,
                CreditHours = dto.CreditHours,
                InstructorId = dto.InstructorId
            };

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            var instructor = await _context.Users.FirstAsync(u => u.Id == dto.InstructorId);

            return new CourseReadDto
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description,
                CreditHours = course.CreditHours,
                InstructorName = instructor.FullName
            };
        }

        public async Task<bool> UpdateAsync(int id, CourseUpdateDto dto)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return false;

            course.Title = dto.Title;
            course.Description = dto.Description;
            course.CreditHours = dto.CreditHours;
            course.InstructorId = dto.InstructorId;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return false;

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}