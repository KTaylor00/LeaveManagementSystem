using Dapper;
using LeaveManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Data.DataAccess;

public class EmployeeLeaveInfoDBService : IEmployeeLeaveInfoDBService
{
    private readonly ISqlDataAccess db;

    public EmployeeLeaveInfoDBService(ISqlDataAccess db)
    {
        this.db = db;
    }

    // Employee DataAccess
    public Task<EmployeeModel> GetEmployee(int employeeId)
    {
        string sql = "Employee_Get " + employeeId.ToString();

        return db.LoadRecord<EmployeeModel, dynamic>(sql, new { });
    }

    public Task<List<EmployeeRequestsModel>> GetEmployeeRequests() => throw new NotImplementedException();

    public Task SaveEmployee(EmployeeModel employee)
    {
        var p = new DynamicParameters();
        p.Add("pkEmployeeId", employee.pkEmployeeId, DbType.Int32);
        p.Add("FirstName", employee.FirstName, DbType.String);
        p.Add("LastName", employee.LastName, DbType.String);

        string sql = "Employee_Save";

        return db.SaveRecord(sql, p);
    }

    public Task DeleteEmployee(int id) => throw new NotImplementedException();

    // Leave DataAccess
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
    public Task<LeaveModel> GetLeaveData(int leaveId) => throw new NotImplementedException();
}
