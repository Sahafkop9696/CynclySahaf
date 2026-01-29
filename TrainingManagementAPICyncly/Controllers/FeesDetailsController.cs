using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class FeesDetailsController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public FeesDetailsController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FeesDetail>>> GetFeesDetails()
    {
        return await _context.FeesDetails.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<FeesDetail>> GetFeesDetail(int id)
    {
        var feesDetail = await _context.FeesDetails.FindAsync(id);

        if (feesDetail == null)
        {
            return NotFound();
        }

        return feesDetail;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutFeesDetail(int id, FeesDetail feesDetail)
    {
        if (id != feesDetail.FeesId)
        {
            return BadRequest();
        }

        _context.Entry(feesDetail).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FeesDetailExists(id))
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
    public async Task<ActionResult<FeesDetail>> PostFeesDetail(FeesDetail feesDetail)
    {
        _context.FeesDetails.Add(feesDetail);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetFeesDetail", new { id = feesDetail.FeesId }, feesDetail);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFeesDetail(int id)
    {
        var feesDetail = await _context.FeesDetails.FindAsync(id);
        if (feesDetail == null)
        {
            return NotFound();
        }

        _context.FeesDetails.Remove(feesDetail);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FeesDetailExists(int id)
    {
        return _context.FeesDetails.Any(e => e.FeesId == id);
    }
}
