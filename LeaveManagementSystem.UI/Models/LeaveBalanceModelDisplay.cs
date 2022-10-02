using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.UI.Models;

public class LeaveBalanceModelDisplay
{
    public int pkLeaveBalanceId { get; set; }
    public int fkEmployeeId { get; set; }
    public int fkLeaveTypeId { get; set; }
    public decimal? LeaveTaken { get; set; }
    public decimal? LeaveAllowed { get; set; }
    public decimal? LeaveLeft { get; set; }
}
