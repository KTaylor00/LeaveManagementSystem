using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Data.DataAccess;

public interface ISqlDataAccess
{
    string ConnectionStringName { get; set; }

    Task<List<T>> LoadData<T, U>(string sql, U parameters);
    Task<T> LoadRecord<T, U>(string sql, U parameters);
    Task SaveRecord<T>(string sql, T parameters);
    Task DeleteRecord<T>(string sql, T parameters);
}
