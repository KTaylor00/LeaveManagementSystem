using LeaveManagementSystem.UI.Models;

namespace LeaveManagementSystem.UI.Services;

public interface IEmployeeLeaveInfoService
{
    Task EmployeeLeaveAuthHeader();
    Task<List<LeaveTypeModelDisplay>> GetLeaveTypes();
    Task<List<EmployeeModelDisplay>> GetEmployees();
    Task<EmployeeModelDisplay> GetEmployee(int employeeId);
    Task<LeaveModelDisplay> GetLeaveData(int leaveId);
    Task<LeaveBalanceModelDisplay> GetBalance(int leaveBalanceId);
    Task SaveLeave(LeaveModelDisplay leave);
    Task SaveLeaveBalance(LeaveBalanceModelDisplay leaveBalance);
}
