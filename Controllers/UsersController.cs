using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using telespamer_backend.Data;
using telespamer_backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace telespamer_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext? _appDbContext;

        public UsersController(AppDbContext? appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<User>> Get()
        {
            var users = await _appDbContext!.Users!.ToListAsync();
            if (users == null)
            {
                return BadRequest("Users not fouund.");
            }
            return Ok(users);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
