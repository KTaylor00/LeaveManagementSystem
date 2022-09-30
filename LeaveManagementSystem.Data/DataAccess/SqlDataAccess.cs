using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Data.DataAccess;

public class SqlDataAccess : ISqlDataAccess
{
	private readonly IConfiguration config;

    public string ConnectionStringName { get; set; } = "DefaultConnection";

    public SqlDataAccess(IConfiguration config)
	{
		this.config = config;
	}

	public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
	{
		string connectionString = config.GetConnectionString(ConnectionStringName);

		using (IDbConnection connection = new SqlConnection(connectionString))
		{
			var data = await connection.QueryAsync<T>(sql, parameters);

			return data.ToList();
		}
	}

	public async Task<T> LoadRecord<T, U>(string sql, U parameters)
	{
        string connectionString = config.GetConnectionString(ConnectionStringName);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            var data = await connection.QueryAsync<T>(sql, parameters);

            return data.FirstOrDefault();
        }
    }

	public async Task SaveRecord<T>(string sql, T parameters)
	{
        string connectionString = config.GetConnectionString(ConnectionStringName);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            await connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);
        }
    } 

	public async Task DeleteRecord<T>(string sql, T parameters)
	{
        string connectionString = config.GetConnectionString(ConnectionStringName);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            await connection.ExecuteAsync(sql, parameters);
        }
    }
}
