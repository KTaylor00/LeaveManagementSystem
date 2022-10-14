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

        // GET: api/EmployeesLeaveInfo/leave-types
        [HttpGet("leave-types")]
        public async Task<ActionResult<List<LeaveTypeModel>>> GetLeaveTypes()
        {
            try
            {
                var output = await data.GetLeaveTypes();
                return Ok(output);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The Get call to api/EmployeesLeaveInfo/leave-types failed.");
                return BadRequest();
            }
        }

        // GET: api/EmployeesLeaveInfo/employees
        [HttpGet("employees")]
        public async Task<ActionResult<List<LeaveTypeModel>>> GetEmployees()
        {
            try
            {
                var output = await data.GetEmployees();
                return Ok(output);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The Get call to api/EmployeesLeaveInfo/employees failed.");
                return BadRequest();
            }
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

        // GET api/EmployeesLeaveInfo/5/leave
        [HttpGet("{leaveId}/leave")]
        public async Task<ActionResult<LeaveModel>> GetLeaveData(int leaveId)
        {
            try
            {
                var output = await data.GetLeaveData(leaveId);
                return Ok(output);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The Get call to {ApiPath} failed. The Id was {leaveId}",
                    $"api/EmployeesLeaveInfo/leaveId/leave", leaveId);
                return BadRequest();
            }
        }

        // GET api/EmployeesLeaveInfo/5/leave-approval
        [HttpGet("{leaveId}/leave-approval")]
        public async Task<ActionResult<LeaveApprovalModel>> GetLeaveApproval(int leaveId)
        {
            try
            {
                var output = await data.GetLeaveApproval(leaveId);
                return Ok(output);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The Get call to {ApiPath} failed. The Id was {leaveId}",
                    $"api/EmployeesLeaveInfo/leaveId/leave-approval", leaveId);
                return BadRequest();
            }
        }

        // GET api/EmployeesLeaveInfo/5/leave-balance
        [HttpGet("{leaveBalanceId}/leave-balance")]
        public async Task<ActionResult<LeaveBalanceModel>> GetLeaveBalance(int leaveBalanceId)
        {
            try
            {
                var output = await data.GetBalance(leaveBalanceId);
                return Ok(output);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The Get call to {ApiPath} failed. The Id was {leaveBalanceId}",
                    $"api/EmployeesLeaveInfo/leaveBalanceId/leave-balance", leaveBalanceId);
                return BadRequest();
            }
        }

        // POST api/EmployeesLeaveInfo/leave-balance
        [HttpPost("leave-balance")]
        public async Task<IActionResult> SaveLeaveBalance([FromBody] LeaveBalanceModel leaveBalance)
        {
            try
            {
                await data.SaveBalance(leaveBalance);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The POST call to api/EmployeesLeaveInfo/leave-balance failed.");
                return BadRequest();
            }
        }

        // POST api/EmployeesLeaveInfo/leave
        [HttpPost("leave")]
        public async Task<IActionResult> SaveLeaveData([FromBody] LeaveModel leave)
        {
            try
            {
                await data.SaveLeave(leave);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The POST call to api/EmployeesLeaveInfo/leave failed.");
                return BadRequest();
            }
        }

        // POST api/EmployeesLeaveInfo/leave-approval
        [HttpPost("leave-approval")]
        public async Task<IActionResult> SaveLeaveApproval([FromBody] LeaveApprovalModel leave)
        {
            try
            {
                await data.SaveLeaveApproval(leave);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "The POST call to api/EmployeesLeaveInfo/leave-approval failed.");
                return BadRequest();
            }
        }
    }
}
