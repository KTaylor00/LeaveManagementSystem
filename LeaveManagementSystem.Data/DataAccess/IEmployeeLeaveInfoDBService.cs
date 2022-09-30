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
    Task<EmployeeModel> SaveEmployee(EmployeeModel employee);
    Task DeleteEmployee(int id);

    // Leave DataAccess
    Task<LeaveModel> GetLeaveData(int leaveId);
    Task<List<LeaveModel>> GetLeavesData();
    Task SaveLeave(LeaveModel leave);
    Task DeleteLeave(int leaveId);

    // LeaveBalance DataAccess
    Task<LeaveBalanceModel> GetBalance(int leaveBalanceId);
    Task SaveBalance(LeaveBalanceModel leaveBalance);
    Task DeleteBalance(int leaveBalanceId);

    // LeaveType DataAccess
    Task<LeaveTypeModel> GetLeaveType(int leaveTypeId);
    Task<List<LeaveTypeModel>> GetLeaveTypes();
    Task SaveLeaveType(LeaveTypeModel leaveType);
    Task DeleteLeaveType(int leaveTypeId);
}
