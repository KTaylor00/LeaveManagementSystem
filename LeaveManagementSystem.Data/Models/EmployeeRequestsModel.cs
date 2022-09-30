using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Data.Models;

public class EmployeeRequestsModel
{
    public int pkEmployeeId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal DaysTaken { get; set; }
    public string? Reason { get; set; }
    public decimal LeaveTaken { get; set; }
    public decimal LeaveAllowed { get; set; }
    public decimal LeaveLeft { get; set; }
    public string? LeaveType { get; set; }
}
