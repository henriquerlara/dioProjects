using Microsoft.AspNetCore.Mvc;
using API.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("Task")]
    public class TaskController : ControllerBase
    {
        private readonly TaskContext _context;

        public TaskController(TaskContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();

            return Ok(task);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var tasks = _context.Tasks.ToList();
            return Ok(tasks);
        }

        [HttpGet("GetByTitle")]
        public IActionResult GetByTitle(string title)
        {
            var tasks = _context.Tasks
                .Where(t => t.Title.Contains(title))
                .ToList();

            return Ok(tasks);
        }

        [HttpGet("GetByDate")]
        public IActionResult GetByDate(DateTime date)
        {
            var tasks = _context.Tasks
                .Where(t => t.Date.Date == date.Date)
                .ToList();

            return Ok(tasks);
        }

        [HttpGet("GetByStatus")]
        public IActionResult GetByStatus(string status)
        {
            var tasks = _context.Tasks
                .Where(t => t.Status == status)
                .ToList();

            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult Create([FromBody] API.Entities.Task task)
        {
            if (task == null) return BadRequest();

            _context.Tasks.Add(task);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] API.Entities.Task updatedTask)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();

            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.Date = updatedTask.Date;
            task.Status = updatedTask.Status;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();

            _context.Tasks.Remove(task);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
