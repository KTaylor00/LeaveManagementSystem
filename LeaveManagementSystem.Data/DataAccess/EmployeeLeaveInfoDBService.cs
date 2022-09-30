using LeaveManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Data.DataAccess;

public class EmployeeLeaveInfoDBService : IEmployeeLeaveInfoDBService
{
    private readonly ISqlDataAccess data;

    public EmployeeLeaveInfoDBService(ISqlDataAccess data)
    {
        this.data = data;
    }

    // Employee DataAccess
    public Task<EmployeeModel> GetEmployee(int id) => throw new NotImplementedException();

    public Task<EmployeeModel> SaveEmployee(EmployeeModel employee) => throw new NotImplementedException();

    public Task DeleteEmployee(int id) => throw new NotImplementedException();

    // Leave DataAccess
    public Task<LeaveModel> GetLeaveData(int leaveId) => throw new NotImplementedException();
    public Task<List<LeaveModel>> GetLeavesData() => throw new NotImplementedException();
    public Task SaveLeave(LeaveModel leave) => throw new NotImplementedException();
    public Task DeleteLeave(int leaveId) => throw new NotImplementedException();

    // LeaveBalance DataAccess
    public Task<LeaveBalanceModel> GetBalance(int leaveBalanceId) => throw new NotImplementedException();
    public Task SaveBalance(LeaveBalanceModel leaveBalance) => throw new NotImplementedException();
    public Task DeleteBalance(int leaveBalanceId) => throw new NotImplementedException();

    // LeaveType DataAccess
    public Task<LeaveTypeModel> GetLeaveType(int leaveTypeId) => throw new NotImplementedException();
    public Task<List<LeaveTypeModel>> GetLeaveTypes() => throw new NotImplementedException();
    public Task SaveLeaveType(LeaveTypeModel leaveType) => throw new NotImplementedException();
    public Task DeleteLeaveType(int leaveTypeId) => throw new NotImplementedException();
}
