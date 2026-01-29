using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class BatchesController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public BatchesController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Batch>>> GetBatches()
    {
        return await _context.Batches.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Batch>> GetBatch(int id)
    {
        var batch = await _context.Batches.FindAsync(id);

        if (batch == null)
        {
            return NotFound();
        }

        return batch;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutBatch(int id, Batch batch)
    {
        if (id != batch.BatchId)
        {
            return BadRequest();
        }

        _context.Entry(batch).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BatchExists(id))
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
    public async Task<ActionResult<Batch>> PostBatch(Batch batch)
    {
        _context.Batches.Add(batch);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetBatch", new { id = batch.BatchId }, batch);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBatch(int id)
    {
        var batch = await _context.Batches.FindAsync(id);
        if (batch == null)
        {
            return NotFound();
        }

        _context.Batches.Remove(batch);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool BatchExists(int id)
    {
        return _context.Batches.Any(e => e.BatchId == id);
    }
}
