// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start!");

if(!Directory.Exists("out"))
{
    Directory.CreateDirectory("out");
}

string result = """{ "output": "value"}""";
File.WriteAllText("out/result.json", result);
var fi = new FileInfo("out/result.json");
Console.WriteLine($"Path to file: {fi.FullName}");
Console.WriteLine("Stop");