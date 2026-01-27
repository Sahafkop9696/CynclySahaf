using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalWebAPITasks8.Models;

namespace FinalWebAPITasks8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficialTasksController : ControllerBase
    {
        //private readonly TaskManagementContext _context;

        //public OfficialTasksController(TaskManagementContext context)
        //{
        //    _context = context;
        //}

        TaskManagementContext _context = new TaskManagementContext();
        // GET: api/OfficialTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfficialTask>>> GetOfficialTasks()
        {
            return await _context.OfficialTasks.ToListAsync();
        }

        // GET: api/OfficialTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OfficialTask>> GetOfficialTask(int id)
        {
            var officialTask = await _context.OfficialTasks.FindAsync(id);

            if (officialTask == null)
            {
                return NotFound();
            }

            return officialTask;
        }

        // PUT: api/OfficialTasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOfficialTask(int id, OfficialTask officialTask)
        {
            if (id != officialTask.TaskId)
            {
                return BadRequest();
            }

            _context.Entry(officialTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfficialTaskExists(id))
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

        // POST: api/OfficialTasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OfficialTask>> PostOfficialTask(OfficialTask officialTask)
        {
            _context.OfficialTasks.Add(officialTask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOfficialTask", new { id = officialTask.TaskId }, officialTask);
        }

        // DELETE: api/OfficialTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfficialTask(int id)
        {
            var officialTask = await _context.OfficialTasks.FindAsync(id);
            if (officialTask == null)
            {
                return NotFound();
            }

            _context.OfficialTasks.Remove(officialTask);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OfficialTaskExists(int id)
        {
            return _context.OfficialTasks.Any(e => e.TaskId == id);
        }
    }
}
