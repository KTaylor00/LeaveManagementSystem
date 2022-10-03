using LeaveManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Data.DataAccess;

public interface IEmployeeLeaveInfoDBService
{
    // Employee DataAccess
    Task<EmployeeModel> GetEmployee(int id);
    Task<List<EmployeeModel>> GetEmployees();
    Task DeleteEmployee(int id);

    // Leave DataAccess
    Task<LeaveModel> GetLeaveData(int leaveId);
    Task SaveLeave(LeaveModel leave);
    Task DeleteLeave(int leaveId);

    // LeaveBalance DataAccess
    Task<LeaveBalanceModel> GetBalance(int leaveBalanceId);
    Task SaveBalance(LeaveBalanceModel leaveBalance);
    Task DeleteBalance(int leaveBalanceId);

    // LeaveType DataAccess
    Task<List<LeaveTypeModel>> GetLeaveTypes();
    Task DeleteLeaveType(int leaveTypeId);
}
