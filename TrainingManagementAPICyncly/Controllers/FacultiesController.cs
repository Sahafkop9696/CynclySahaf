using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class FacultiesController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public FacultiesController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Faculty>>> GetFaculties()
    {
        return await _context.Faculties.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Faculty>> GetFaculty(int id)
    {
        var faculty = await _context.Faculties.FindAsync(id);

        if (faculty == null)
        {
            return NotFound();
        }

        return faculty;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutFaculty(int id, Faculty faculty)
    {
        if (id != faculty.FacultyId)
        {
            return BadRequest();
        }

        _context.Entry(faculty).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FacultyExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Faculty>> PostFaculty(Faculty faculty)
    {
        _context.Faculties.Add(faculty);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetFaculty", new { id = faculty.FacultyId }, faculty);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFaculty(int id)
    {
        var faculty = await _context.Faculties.FindAsync(id);
        if (faculty == null)
        {
            return NotFound();
        }

        _context.Faculties.Remove(faculty);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FacultyExists(int id)
    {
        return _context.Faculties.Any(e => e.FacultyId == id);
    }
}
