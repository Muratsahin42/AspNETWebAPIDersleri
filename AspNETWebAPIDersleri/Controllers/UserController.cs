using LMS.Data;
using LMS.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNETWebAPIDersleri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly LMSDBContext context;
        public UserController()
        {
            context = new LMSDBContext();
        }
        [HttpGet]
        public List<User> Get()
        {
            return context.Users.ToList();
        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return context.Users.Find(id);
        }
        [HttpPost]
        public void Post([FromBody] User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
