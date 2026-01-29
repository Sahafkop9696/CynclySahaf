using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class TraineeAssignmentsController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public TraineeAssignmentsController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TraineeAssignment>>> GetTraineeAssignments()
    {
        return await _context.TraineeAssignments.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TraineeAssignment>> GetTraineeAssignment(int id)
    {
        var traineeAssignment = await _context.TraineeAssignments.FindAsync(id);

        if (traineeAssignment == null)
        {
            return NotFound();
        }

        return traineeAssignment;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTraineeAssignment(int id, TraineeAssignment traineeAssignment)
    {
        if (id != traineeAssignment.AssignmentId)
        {
            return BadRequest();
        }

        _context.Entry(traineeAssignment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TraineeAssignmentExists(id))
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
    public async Task<ActionResult<TraineeAssignment>> PostTraineeAssignment(TraineeAssignment traineeAssignment)
    {
        _context.TraineeAssignments.Add(traineeAssignment);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTraineeAssignment", new { id = traineeAssignment.AssignmentId }, traineeAssignment);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTraineeAssignment(int id)
    {
        var traineeAssignment = await _context.TraineeAssignments.FindAsync(id);
        if (traineeAssignment == null)
        {
            return NotFound();
        }

        _context.TraineeAssignments.Remove(traineeAssignment);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TraineeAssignmentExists(int id)
    {
        return _context.TraineeAssignments.Any(e => e.AssignmentId == id);
    }
}
