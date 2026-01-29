using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class BatchDetailsController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public BatchDetailsController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BatchDetail>>> GetBatchDetails()
    {
        return await _context.BatchDetails.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BatchDetail>> GetBatchDetail(int id)
    {
        var batchDetail = await _context.BatchDetails.FindAsync(id);

        if (batchDetail == null)
        {
            return NotFound();
        }

        return batchDetail;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutBatchDetail(int id, BatchDetail batchDetail)
    {
        if (id != batchDetail.BatchDetailId)
        {
            return BadRequest();
        }

        _context.Entry(batchDetail).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BatchDetailExists(id))
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
    public async Task<ActionResult<BatchDetail>> PostBatchDetail(BatchDetail batchDetail)
    {
        _context.BatchDetails.Add(batchDetail);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetBatchDetail", new { id = batchDetail.BatchDetailId }, batchDetail);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBatchDetail(int id)
    {
        var batchDetail = await _context.BatchDetails.FindAsync(id);
        if (batchDetail == null)
        {
            return NotFound();
        }

        _context.BatchDetails.Remove(batchDetail);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool BatchDetailExists(int id)
    {
        return _context.BatchDetails.Any(e => e.BatchDetailId == id);
    }
}
