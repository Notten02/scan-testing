// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

Console.WriteLine("Hello, password ;)");
string SuperSecretPasswordThingy = "p@assw0rd"; // oopsie
string connectionString = @"127.0.0.1\sql";
string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@Username", "newAdmin");
    command.Parameters.AddWithValue("@Password", "TheAdminP@ssw0rdbhooo"); // daisy
    connection.Open();
    command.ExecuteNonQuery();
}
