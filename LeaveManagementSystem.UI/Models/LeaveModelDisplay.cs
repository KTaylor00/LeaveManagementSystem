using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.UI.Models;

public class LeaveModelDisplay
{
    public int pkLeaveId { get; set; }
    public int fkEmployeeId { get; set; }
    public int fkLeaveTypeId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? DaysTaken { get; set; }
    public string? Reason { get; set; }
}
