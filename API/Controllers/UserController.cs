using API.DataInterface;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DBContext db;
        public UserController()
        {
            db = new DBContext();
        }
        [HttpPost("register")]
        public bool Login([FromBody] User user)
        {
            if (db.User.Count() == 0)
            {
                db.User.Add(user);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPost("login")]
        public bool Register([FromBody] User userInput)
        {
            User user = db.User.First<User>();
            if (user.Name == userInput.Name && user.Password == userInput.Password)
                return true;
            else
                return false;
        }
    }
}
