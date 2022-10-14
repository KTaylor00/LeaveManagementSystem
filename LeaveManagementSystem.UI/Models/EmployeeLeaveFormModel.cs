namespace LeaveManagementSystem.UI.Models;

public class EmployeeLeaveFormModel
{
    public int fkEmployeeId { get; set; }
    public int fkLeaveTypeId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FullName { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? DaysTaken { get; set; }
    public string? Reason { get; set; }
    public decimal? LeaveTaken { get; set; }
    public decimal? LeaveAllowed { get; set; }
    public decimal? LeaveLeft { get; set; }
    public string? LeaveType { get; set; }
    public string? Approval { get; set; }
    public string? ApprovalDate { get; set; }
    public bool Approved { get; set; }
    public string? ApprovedBy { get; set; }
    public DateTime DateApproved { get; set; }
}
