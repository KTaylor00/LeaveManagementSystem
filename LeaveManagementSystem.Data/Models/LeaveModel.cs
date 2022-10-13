using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Data.Models;

public class LeaveModel
{
    public int pkLeaveId { get; set; }
    public int fkEmployeeId { get; set; }
    public int fkLeaveTypeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? LeaveType { get; set; }
    public decimal DaysTaken { get; set; }
    public string? Reason { get; set; }
    public bool Approved { get; set; }
    public string? ApprovedBy { get; set; }
    public DateTime DateApproved { get; set; }
}
