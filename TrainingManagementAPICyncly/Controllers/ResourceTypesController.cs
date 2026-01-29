using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.API.Data;
using TrainingManagement.API.Models;

namespace TrainingManagement.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ResourceTypesController : ControllerBase
{
    private readonly TrainingManagementDbContext _context;

    public ResourceTypesController(TrainingManagementDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ResourceType>>> GetResourceTypes()
    {
        return await _context.ResourceTypes.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ResourceType>> GetResourceType(int id)
    {
        var resourceType = await _context.ResourceTypes.FindAsync(id);

        if (resourceType == null)
        {
            return NotFound();
        }

        return resourceType;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutResourceType(int id, ResourceType resourceType)
    {
        if (id != resourceType.ResourceTypeId)
        {
            return BadRequest();
        }

        _context.Entry(resourceType).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ResourceTypeExists(id))
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
    public async Task<ActionResult<ResourceType>> PostResourceType(ResourceType resourceType)
    {
        _context.ResourceTypes.Add(resourceType);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetResourceType", new { id = resourceType.ResourceTypeId }, resourceType);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteResourceType(int id)
    {
        var resourceType = await _context.ResourceTypes.FindAsync(id);
        if (resourceType == null)
        {
            return NotFound();
        }

        _context.ResourceTypes.Remove(resourceType);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ResourceTypeExists(int id)
    {
        return _context.ResourceTypes.Any(e => e.ResourceTypeId == id);
    }
}
