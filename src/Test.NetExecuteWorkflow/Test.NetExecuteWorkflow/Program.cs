// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start!");

if(!Directory.Exists("out"))
{
    Directory.CreateDirectory("out");
}

string result = """{ "output": "value"}""";
File.WriteAllText("out/result.json", result);
Console.WriteLine("Stop");