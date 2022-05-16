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
                    _repository.SaveChanges();
                }
            }

            return Ok(_repository.GetTasks().ToList()); 
        }

        //PUT: api/Tasks/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(int id, Models.Task task)
        {

            var task_repo = _repository.GetTask(id);
            if (task_repo == null)
            {
                return NotFound();
            }
            if (id != task.Id)
            {
                return BadRequest();
            }

            task_repo.Title = task.Title;
            task_repo.IsCompleted = task.IsCompleted;

            _repository.SaveChanges();

            return NoContent();
        }
    }
}
