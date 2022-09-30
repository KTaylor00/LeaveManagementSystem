using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeaveManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesLeaveInfoController : ControllerBase
    {
        // GET: api/EmployeesLeaveInfo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/EmployeesLeaveInfo/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/EmployeesLeaveInfo
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/EmployeesLeaveInfo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/EmployeesLeaveInfo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
