// See https://aka.ms/new-console-template for more information
Console.WriteLine("I don't need a ctor!");
Type type = Type.GetType(Environment.GetCommandLineArgs()[1]);
var surprise = Activator.CreateInstance(type!); // bad example, but exposes your innarts
Console.WriteLine(surprise.ToString());