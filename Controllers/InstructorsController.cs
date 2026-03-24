using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Eng.DTOs.Instructor;
using Web_Eng.Services.Interfaces;


namespace Web_Eng.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<InstructorReadDto>>> GetAll()
        {
            return Ok(await _instructorService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InstructorReadDto>> GetById(int id)
        {
            var instructor = await _instructorService.GetByIdAsync(id);
            if (instructor == null) return NotFound();
            return Ok(instructor);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<InstructorReadDto>> Create(InstructorCreateDto dto)
        {
            var result = await _instructorService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, InstructorUpdateDto dto)
        {
            var updated = await _instructorService.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _instructorService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}