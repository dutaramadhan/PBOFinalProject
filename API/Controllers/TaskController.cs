using API.DataInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using Task = API.Models.Task;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly DBContext db;
        public TaskController()
        {
            db = new DBContext();
        }

        [HttpGet]
        public List<Task> GetAll()
        {
            List<Task> tasks = db.Tasks.ToList();
            return tasks;
        }

        [HttpGet("{id}")]
        public Task? GetById(int id)
        {
            Task? task = db.Tasks.Find(id);
            return task;
        }

        [HttpPost]
        public void Create([FromBody] Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Task task)
        {
            try
            {
                db.Tasks.Update(task);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Task? task = db.Tasks.Find(id);

            if (task == null)
                return NotFound();

            db.Tasks.Remove(task);
            db.SaveChanges();

            return Ok();
        }
    }
}
