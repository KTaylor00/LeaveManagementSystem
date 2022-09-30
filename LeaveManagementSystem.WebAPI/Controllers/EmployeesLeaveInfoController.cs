using LeaveManagementSystem.Data.DataAccess;
using LeaveManagementSystem.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LeaveManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesLeaveInfoController : ControllerBase
    {
        private readonly IEmployeeLeaveInfoDBService data;
        private readonly ILogger<EmployeesLeaveInfoController> logger;

        public EmployeesLeaveInfoController(IEmployeeLeaveInfoDBService data, ILogger<EmployeesLeaveInfoController> logger)
        {
            this.data = data;
            this.logger = logger;
        }

        // GET: api/EmployeesLeaveInfo/leaves-data
        [HttpGet("leaves-data")]
        public async Task<ActionResult<List<LeaveModel>>> GetLeavesData()
        {
            throw new NotImplementedException();
        }

        // GET api/EmployeesLeaveInfo/5/employee
        [HttpGet("{employeeId}/employee")]
        public async Task<ActionResult<EmployeeModel>> GetEmployee(int employeeId)
        {
            try
            {
                var output = await data.GetEmployee(employeeId);
                return Ok(output);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The Get call to {ApiPath} failed. The Id was {employeeId}", 
                    $"api/EmployeesLeaveInfo/employeeId/employee", employeeId);
                return BadRequest();
            }
        }

        // POST api/EmployeesLeaveInfo/employee
        [HttpPost("employee")]
        public async Task<IActionResult> SaveEmployeeData([FromBody] EmployeeModel employee)
        {
            try
            {
                await data.SaveEmployee(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The POST call to api/EmployeesLeaveInfo/employee failed.");
                return BadRequest();
            }
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
