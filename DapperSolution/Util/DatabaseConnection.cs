using System.Data;
using Microsoft.Data.SqlClient;

namespace DapperSolution.Util;

public class DatabaseConnection
{

    private static string ConnectionStr = "Server=DESKTOP-DFFR2JS\\SQLEXPRESS;Database=SchoolP32;Trusted_Connection=True;TrustServerCertificate=True;"; 

    public static IDbConnection GetConnection()
    {
        return new SqlConnection(ConnectionStr);
    }
}