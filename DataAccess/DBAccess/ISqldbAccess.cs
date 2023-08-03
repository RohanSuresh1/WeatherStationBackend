namespace DataAccess.DBAccess;

public interface ISqldbAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "WMS");
    Task<int> SaveData<T, U>(string storedProcedure, U parameters, string connectionId = "WMS");
    Task<int> Insert<T, U>(string storedProcedure, U parameters, string connectionId = "WMS");
}