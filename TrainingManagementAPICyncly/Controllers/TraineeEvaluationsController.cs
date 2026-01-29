using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class TraineeEvaluationsController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public TraineeEvaluationsController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TraineeEvaluation>>> GetTraineeEvaluations()
    {
        return await _context.TraineeEvaluations.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TraineeEvaluation>> GetTraineeEvaluation(int id)
    {
        var traineeEvaluation = await _context.TraineeEvaluations.FindAsync(id);

        if (traineeEvaluation == null)
        {
            return NotFound();
        }

        return traineeEvaluation;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTraineeEvaluation(int id, TraineeEvaluation traineeEvaluation)
    {
        if (id != traineeEvaluation.TraineeEvaluationId)
        {
            return BadRequest();
        }

        _context.Entry(traineeEvaluation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TraineeEvaluationExists(id))
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
    public async Task<ActionResult<TraineeEvaluation>> PostTraineeEvaluation(TraineeEvaluation traineeEvaluation)
    {
        _context.TraineeEvaluations.Add(traineeEvaluation);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTraineeEvaluation", new { id = traineeEvaluation.TraineeEvaluationId }, traineeEvaluation);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTraineeEvaluation(int id)
    {
        var traineeEvaluation = await _context.TraineeEvaluations.FindAsync(id);
        if (traineeEvaluation == null)
        {
            return NotFound();
        }

        _context.TraineeEvaluations.Remove(traineeEvaluation);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TraineeEvaluationExists(int id)
    {
        return _context.TraineeEvaluations.Any(e => e.TraineeEvaluationId == id);
    }
}
