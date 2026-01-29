using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class FacultySubjectsController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public FacultySubjectsController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FacultySubject>>> GetFacultiesSubjects()
    {
        return await _context.FacultiesSubjects.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<FacultySubject>> GetFacultySubject(int id)
    {
        var facultySubject = await _context.FacultiesSubjects.FindAsync(id);

        if (facultySubject == null)
        {
            return NotFound();
        }

        return facultySubject;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutFacultySubject(int id, FacultySubject facultySubject)
    {
        if (id != facultySubject.FacultySubjectId)
        {
            return BadRequest();
        }

        _context.Entry(facultySubject).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FacultySubjectExists(id))
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
    public async Task<ActionResult<FacultySubject>> PostFacultySubject(FacultySubject facultySubject)
    {
        _context.FacultiesSubjects.Add(facultySubject);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetFacultySubject", new { id = facultySubject.FacultySubjectId }, facultySubject);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFacultySubject(int id)
    {
        var facultySubject = await _context.FacultiesSubjects.FindAsync(id);
        if (facultySubject == null)
        {
            return NotFound();
        }

        _context.FacultiesSubjects.Remove(facultySubject);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FacultySubjectExists(int id)
    {
        return _context.FacultiesSubjects.Any(e => e.FacultySubjectId == id);
    }
}
