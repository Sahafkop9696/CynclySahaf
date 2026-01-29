using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class EvaluationsController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public EvaluationsController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Evaluation>>> GetEvaluations()
    {
        return await _context.Evaluations.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Evaluation>> GetEvaluation(int id)
    {
        var evaluation = await _context.Evaluations.FindAsync(id);

        if (evaluation == null)
        {
            return NotFound();
        }

        return evaluation;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEvaluation(int id, Evaluation evaluation)
    {
        if (id != evaluation.EvaluationId)
        {
            return BadRequest();
        }

        _context.Entry(evaluation).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EvaluationExists(id))
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
    public async Task<ActionResult<Evaluation>> PostEvaluation(Evaluation evaluation)
    {
        _context.Evaluations.Add(evaluation);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetEvaluation", new { id = evaluation.EvaluationId }, evaluation);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEvaluation(int id)
    {
        var evaluation = await _context.Evaluations.FindAsync(id);
        if (evaluation == null)
        {
            return NotFound();
        }

        _context.Evaluations.Remove(evaluation);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool EvaluationExists(int id)
    {
        return _context.Evaluations.Any(e => e.EvaluationId == id);
    }
}
