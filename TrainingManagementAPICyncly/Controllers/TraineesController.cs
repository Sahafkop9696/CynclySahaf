using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class TraineesController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public TraineesController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Trainee>>> GetTrainees()
    {
        return await _context.Trainees.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Trainee>> GetTrainee(int id)
    {
        var trainee = await _context.Trainees.FindAsync(id);

        if (trainee == null)
        {
            return NotFound();
        }

        return trainee;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTrainee(int id, Trainee trainee)
    {
        if (id != trainee.TraineeId)
        {
            return BadRequest();
        }

        _context.Entry(trainee).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TraineeExists(id))
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
    public async Task<ActionResult<Trainee>> PostTrainee(Trainee trainee)
    {
        _context.Trainees.Add(trainee);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTrainee", new { id = trainee.TraineeId }, trainee);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTrainee(int id)
    {
        var trainee = await _context.Trainees.FindAsync(id);
        if (trainee == null)
        {
            return NotFound();
        }

        _context.Trainees.Remove(trainee);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TraineeExists(int id)
    {
        return _context.Trainees.Any(e => e.TraineeId == id);
    }
}
