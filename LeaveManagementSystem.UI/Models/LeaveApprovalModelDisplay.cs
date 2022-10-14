using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.UI.Models;

public class LeaveApprovalModelDisplay
{
    public int pkLeaveId { get; set; }
    public bool Approved { get; set; }
    public string? ApprovedBy { get; set; }
    public DateTime DateApproved { get; set; }
}
