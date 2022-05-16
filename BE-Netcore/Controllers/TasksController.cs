using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BE_Netcore.Data;
using System.Net.Http;
using Newtonsoft.Json;

namespace BE_Netcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepo _repository;

        public TasksController(ITaskRepo repository)
        {
            _repository = repository;
        }

        // GET: api/Tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Task>>> GetTasksAsync()
        {

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://hipsum.co/api/?type=hipster-centric&sentences=3")) //TODO: replace sentances with random value
                {

                    var apiResponse = await response.Content.ReadAsStringAsync();

                    var titulos = JsonConvert.DeserializeObject<List<string>>(apiResponse).First();

                    var listatitulos = titulos.Split('.', StringSplitOptions.RemoveEmptyEntries);

                        foreach (var titulo in listatitulos)
                        {
                            _repository.CreateTask(new Models.Task() { Title = titulo });
                        };
                }
            }

            return Ok(_repository.GetTasks().ToList()); 
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
