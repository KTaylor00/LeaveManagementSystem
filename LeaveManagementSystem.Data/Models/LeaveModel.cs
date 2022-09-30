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
    public decimal StartDate { get; set; }
    public decimal EndDate { get; set; }
    public decimal DaysTaken { get; set; }
}
