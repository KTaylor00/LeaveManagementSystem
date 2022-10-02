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
    public Task SaveLeave(LeaveModel leave)
    {
        var p = new DynamicParameters();
        p.Add("pkLeaveId", leave.pkLeaveId, DbType.Int32);
        p.Add("fkEmployeeId", leave.fkEmployeeId, DbType.Int32);
        p.Add("fkLeaveTypeId", leave.fkLeaveTypeId, DbType.Int32);
        p.Add("StartDate", leave.StartDate, DbType.DateTime);
        p.Add("EndDate", leave.EndDate, DbType.DateTime);
        p.Add("DaysTaken", leave.DaysTaken, DbType.Decimal);
        p.Add("Reason", leave.Reason, DbType.String);

        string sql = "Leave_Save";

        return db.SaveRecord(sql, p);
    }
    public Task DeleteLeave(int leaveId) => throw new NotImplementedException();

    // LeaveBalance DataAccess
    public Task<LeaveBalanceModel> GetBalance(int leaveBalanceId)
    {
        string sql = "LeaveBalance_Get " + leaveBalanceId.ToString();

        return db.LoadRecord<LeaveBalanceModel, dynamic>(sql, new { });
    }

    public Task SaveBalance(LeaveBalanceModel leaveBalance)
    {
        var p = new DynamicParameters();
        p.Add("pkLeaveBalanceId", leaveBalance.pkLeaveBalanceId, DbType.Int32);
        p.Add("fkEmployeeId", leaveBalance.fkEmployeeId, DbType.Int32);
        p.Add("fkLeaveTypeId", leaveBalance.fkLeaveTypeId, DbType.Int32);
        p.Add("LeaveTaken", leaveBalance.LeaveTaken, DbType.Decimal);
        p.Add("LeaveAllowed", leaveBalance.LeaveAllowed, DbType.Decimal);

        string sql = "LeaveBalance_Save";

        return db.SaveRecord(sql, p);
    }
    public Task DeleteBalance(int leaveBalanceId) => throw new NotImplementedException();

    // LeaveType DataAccess
    public Task<List<LeaveTypeModel>> GetLeaveTypes()
    {
        string sql = "SELECT * FROM LeaveType";

        return db.LoadData<LeaveTypeModel, dynamic>(sql, new { });
    }

    public Task DeleteLeaveType(int leaveTypeId) => throw new NotImplementedException();

    public Task<LeaveModel> GetLeaveData(int leaveId)
    {
        string sql = "Leave_Get " + leaveId.ToString();

        return db.LoadRecord<LeaveModel, dynamic>(sql, new { });
    }
}
