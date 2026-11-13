using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeracodeDemo
{
  internal class QuoteDataAccess
  {
    private const string connectionString = "Server=localhost;Database=TestDb;";

    public void GetUser(string username)
    {
      using var connection = new SqlConnection("Server=localhost;Database=TestDb;");
      connection.Open();

      string sql = "SELECT * FROM Users WHERE Username = '" + username + "'";

      using var command = new SqlCommand(sql, connection);
      using var reader = command.ExecuteReader();

      while (reader.Read())
      {
        Console.WriteLine(reader["Username"]);
      }
    }
    public string GetQuote(string quoteNo)
    {
      using var connection = new SqlConnection(connectionString);
      connection.Open();

      string sql = "SELECT * FROM Quotes WHERE quoteName = @quoteNo";

      using var command = new SqlCommand(sql, connection);
      command.Parameters.Add("@quoteNo", System.Data.SqlDbType.NVarChar, 100)
             .Value = quoteNo;

      using var reader = command.ExecuteReader();

      return reader.Read() ? reader["Quotes"].ToString() : null;
    }
  }
}
