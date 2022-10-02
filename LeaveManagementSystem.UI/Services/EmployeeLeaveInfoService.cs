using LeaveManagementSystem.UI.Models;

namespace LeaveManagementSystem.UI.Services;

public class EmployeeLeaveInfoService : IEmployeeLeaveInfoService
{
	private readonly HttpClient client;
	private readonly IAuthService authService;

	public EmployeeLeaveInfoService(HttpClient client, IAuthService authService)
	{
		this.client = client;
		this.authService = authService;
	}

    public async Task EmployeeLeaveAuthHeader()
    {
        await authService.GetToken();
        client.DefaultRequestHeaders.Authorization = authService.AuthHeaderValue();
    }

	public async Task<LeaveBalanceModelDisplay> GetBalance(int leaveBalanceId)
	{
        return await client.GetFromJsonAsync<LeaveBalanceModelDisplay>($"EmployeesLeaveInfo/{leaveBalanceId}/leave-balance");
    }

	public async Task<EmployeeModelDisplay> GetEmployee(int employeeId)
	{
		return await client.GetFromJsonAsync<EmployeeModelDisplay>($"EmployeesLeaveInfo/{employeeId}/employee");
	}

	public async Task<LeaveModelDisplay> GetLeaveData(int leaveId)
	{
        return await client.GetFromJsonAsync<LeaveModelDisplay>($"EmployeesLeaveInfo/{leaveId}/leave");
    }

	public async Task<List<LeaveTypeModelDisplay>> GetLeaveTypes()
	{
		return await client.GetFromJsonAsync<List<LeaveTypeModelDisplay>>("EmployeesLeaveInfo/leave-types");
	}

	public async Task SaveEmployee(EmployeeModelDisplay employee)
	{
		await client.PostAsJsonAsync("EmployeesLeaveInfo/employee", employee);
	}

	public async Task SaveLeave(LeaveModelDisplay leave)
	{
		await client.PostAsJsonAsync("EmployeesLeaveInfo/leave", leave);
	}

	public async Task SaveLeaveBalance(LeaveBalanceModelDisplay leaveBalance)
	{
		await client.PostAsJsonAsync("EmployeesLeaveInfo/leave-balance", leaveBalance);

    }
}
