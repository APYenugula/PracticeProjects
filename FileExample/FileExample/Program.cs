// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

File.Create("Warsh.txt");
if (File.Exists("Warsh.txt")){
    Console.WriteLine("File Created");

}
else
{
    Console.WriteLine("File modified");
}
var file1 = File.Open("Warsh.txt", FileMode.Append);
// Write file using StreamWriter
using (StreamWriter writer = new StreamWriter(Path.GetFullPath("Warsh.text")))
{
    writer.WriteLine("Monica Rathbun");
    writer.WriteLine("Vidya Agarwal");
    writer.WriteLine("Mahesh Chand");
    writer.WriteLine("Vijay Anand");
    writer.WriteLine("Jignesh Trivedi");
}
// Read a file
//string readText = File.ReadAllText(Path.GetFullPath("Suresh.text"));
string readText1 = File.ReadAllText(Path.GetFullPath("Warsh.text"));
//Console.WriteLine(readText);
Console.WriteLine(readText1);
