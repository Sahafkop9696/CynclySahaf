using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

//[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CollegesController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public CollegesController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<College>>> GetColleges()
    {
        return await _context.Colleges.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<College>> GetCollege(int id)
    {
        var college = await _context.Colleges.FindAsync(id);

        if (college == null)
        {
            return NotFound();
        }

        return college;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutCollege(int id, College college)
    {
        if (id != college.CollegeId)
        {
            return BadRequest();
        }

        _context.Entry(college).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CollegeExists(id))
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
    public async Task<ActionResult<College>> PostCollege(College college)
    {
        _context.Colleges.Add(college);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetCollege", new { id = college.CollegeId }, college);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCollege(int id)
    {
        var college = await _context.Colleges.FindAsync(id);
        if (college == null)
        {
            return NotFound();
        }

        _context.Colleges.Remove(college);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool CollegeExists(int id)
    {
        return _context.Colleges.Any(e => e.CollegeId == id);
    }
}
