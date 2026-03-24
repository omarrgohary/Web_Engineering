using Microsoft.EntityFrameworkCore;
using Web_Eng.Data;
using Web_Eng.DTOs.Enrollment;
using Web_Eng.Models;
using Web_Eng.Services.Interfaces;


namespace Web_Eng.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly AppDbContext _context;

        public EnrollmentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<EnrollmentReadDto>> GetAllAsync()
        {
            return await _context.Enrollments
                .AsNoTracking()
                .Include(e => e.Student)
                .Include(e => e.Course)
                .Select(e => new EnrollmentReadDto
                {
                    StudentId = e.StudentId,
                    StudentName = e.Student.Name,
                    CourseId = e.CourseId,
                    CourseTitle = e.Course.Title,
                    EnrolledAt = e.EnrolledAt
                })
                .ToListAsync();
        }

        public async Task<EnrollmentReadDto> CreateAsync(EnrollmentCreateDto dto)
        {
            var enrollment = new Enrollment
            {
                StudentId = dto.StudentId,
                CourseId = dto.CourseId
            };

            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();

            var student = await _context.Students.FirstAsync(s => s.Id == dto.StudentId);
            var course = await _context.Courses.FirstAsync(c => c.Id == dto.CourseId);

            return new EnrollmentReadDto
            {
                StudentId = enrollment.StudentId,
                StudentName = student.Name,
                CourseId = enrollment.CourseId,
                CourseTitle = course.Title,
                EnrolledAt = enrollment.EnrolledAt
            };
        }

        public async Task<bool> DeleteAsync(int studentId, int courseId)
        {
            var enrollment = await _context.Enrollments
                .FirstOrDefaultAsync(e => e.StudentId == studentId && e.CourseId == courseId);

            if (enrollment == null) return false;

            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}