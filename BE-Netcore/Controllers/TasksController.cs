using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BE_Netcore.Data;
using BE_Netcore.Models;
using BE_Netcore.Service;

namespace BE_Netcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepo _repository;

        //  private readonly BE_NetcoreContext _context;
        //  private readonly HipsumService _service;
        //private readonly MockTaskRepo _repository = new MockTaskRepo();
        public TasksController(ITaskRepo repository)
        {
            _repository = repository;
        }

        // GET: api/Tasks
        [HttpGet]
        public ActionResult<IEnumerable<Models.Task>> GetTask()
        {
            var tasklist = _repository.GetTasks().ToList();

            return Ok(tasklist); 
        }
        // PUT: api/Tasks/5
        
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTask(int id, Models.Task task)
        //{
        //    if (id != task.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(task).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TaskExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //private bool TaskExists(int id)
        //{
        //    return _context.Task.Any(e => e.Id == id);
        //}

        //// GET: api/Tasks/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Models.Task>> GetTask(int id)
        //{
        //    var task = await _context.Task.FindAsync(id);

        //    if (task == null)
        //    {
        //        return NotFound();
        //    }

        //    return task;
        //}



        //// POST: api/Tasks
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Models.Task>> PostTask(Models.Task task)
        //{
        //    _context.Task.Add(task);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTask", new { id = task.Id }, task);
        //}

        //// DELETE: api/Tasks/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTask(int id)
        //{
        //    var task = await _context.Task.FindAsync(id);
        //    if (task == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Task.Remove(task);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


    }
}
