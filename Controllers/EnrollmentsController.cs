using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Eng.DTOs.Enrollment;
using Web_Eng.Services.Interfaces;


namespace Web_Eng.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentsController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<EnrollmentReadDto>>> GetAll()
        {
            return Ok(await _enrollmentService.GetAllAsync());
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Instructor")]
        public async Task<ActionResult<EnrollmentReadDto>> Create(EnrollmentCreateDto dto)
        {
            var result = await _enrollmentService.CreateAsync(dto);
            return Ok(result);
        }

        [HttpDelete("{studentId}/{courseId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int studentId, int courseId)
        {
            var deleted = await _enrollmentService.DeleteAsync(studentId, courseId);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}