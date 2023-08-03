using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace DataAccess.DBAccess;

public class SqldbAccess : ISqldbAccess
{
    private readonly IConfiguration _config;

    public SqldbAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "WMS")
    {
        using IDbConnection connection = new MySqlConnection(_config.GetConnectionString(connectionId));
        return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }
    public async Task<int> SaveData<T, U>(string storedProcedure, U parameters, string connectionId = "WMS")
    {
        using IDbConnection connection = new MySqlConnection(_config.GetConnectionString(connectionId));
        var updatedRows = await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        return updatedRows;
    }
    public async Task<int> Insert<T, U>(string storedProcedure, U parameters, string connectionId = "WMS")
    {
        using IDbConnection connection = new MySqlConnection(_config.GetConnectionString(connectionId));
        var insertedId = await connection.QueryFirstAsync<int>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        return insertedId;
    }
}