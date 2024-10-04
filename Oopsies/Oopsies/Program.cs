using System.Diagnostics;

//injecting a command line argument and pushing it into shell

Console.WriteLine("Hello, World!");
string parameter = Environment.GetCommandLineArgs()[1];
Console.WriteLine($"running '{parameter}'!");

// Start a new process
Process process = new Process();
process.StartInfo.FileName = "cmd.exe";
process.StartInfo.Arguments = $"/C {parameter}";
process.Start();
