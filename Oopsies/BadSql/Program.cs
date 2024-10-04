// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

string arg = Environment.GetCommandLineArgs()[1];
using SqlConnection conn = new(@"127.0.0.1\sqli");
conn.Open();
string queryStatement = "SELECT * FROM Users WHERE username = '" + arg + "'";
using SqlCommand cmd = new(queryStatement, conn);
using SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["username"]);
}
