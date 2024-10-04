// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;


//way of doing it wrong 1
using (MD5 md5 = MD5.Create())
{
    byte[] inputBytes = Encoding.ASCII.GetBytes(Environment.GetCommandLineArgs()[1]);
    byte[] hashBytes = md5.ComputeHash(inputBytes);
    string secret = Convert.ToBase64String(hashBytes);
    Console.WriteLine(secret);
}

// and 2
byte[] inputBytes2 = Encoding.ASCII.GetBytes(Environment.GetCommandLineArgs()[2]);
byte[] hashBytes2 = MD5.HashData(inputBytes2);
string secret2 = Convert.ToBase64String(hashBytes2);
Console.WriteLine(secret2);
