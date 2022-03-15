using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerApp.data;
using TaskManagerApp.Models;

namespace TaskManagerApp.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public TaskController(ApiDbContext context)
        {
            _context = context;
        }

        // Get All Tasks
        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {
            var tasks = await _context.tasks.ToListAsync();
            return Ok(tasks);
        }
        // Get a single Task
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTask(int id)
        {
            var task = await _context.tasks.FirstOrDefaultAsync(x => x.Id == id);
            if(task == null) return NotFound();
            return Ok(task);
        }
        // Create a Task
        [HttpPost]
        public async Task<IActionResult> CreateTask(TaskModel data)
        {
            if(ModelState.IsValid){
                await _context.tasks.AddAsync(data);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetTask", new {data.Id}, data);
            }
            return new JsonResult("Something went wrong") { StatusCode = 500};
        }
        // Update a Task
        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateTask(int id, TaskModel data)
        {
                
                // check if task exit
                var existingTask = await _context.tasks.FirstOrDefaultAsync(x => x.Id == id);
                if(existingTask == null) return NotFound();

                existingTask.Title = data.Title;
                existingTask.Content = data.Content;
                existingTask.status = data.status;
                await _context.SaveChangesAsync();
                return Ok("Task Updated");

        }
        // Delete a Task
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _context.tasks.FirstOrDefaultAsync(x => x.Id == id);
            if(task == null) return NotFound();
            _context.tasks.Remove(task);
            await _context.SaveChangesAsync();
            return Ok($"Task {task.Id} was deleted ");
        }

        // [HttpGet]
        // public IActionResult Test()
        // {
        //     return Ok("Testing the task endpoint....");
        // }
    }
}