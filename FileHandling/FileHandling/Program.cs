// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text;

string fileName = @"C:\Temp\MaheshTXFI.txt";
FileInfo fi = new FileInfo(fileName);
string justFileName = fi.Name;
Console.WriteLine("File Name: " + justFileName);

string fullFileName = fi.FullName;
Console.WriteLine("File Name: " + fullFileName);

string extn = fi.Extension;
Console.WriteLine("File Extension: {0}", extn);

string directoryName = fi.DirectoryName;
Console.WriteLine("Directory Name: {0}", directoryName);

bool exists = fi.Exists;
Console.WriteLine(exists);

DateTime creationTime = fi.CreationTime;
Console.WriteLine("Creation time: {0}", creationTime);

DateTime accessTime = fi.LastAccessTime;
Console.WriteLine("Last access time: {0}", accessTime);

DateTime updatedTime = fi.LastWriteTime;
Console.WriteLine("Last write time: {0}", updatedTime);
Console.WriteLine(" ");

using (StreamWriter sw = fi.CreateText())
{
    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
    sw.WriteLine("Author: Mahesh Chand");
    sw.WriteLine("Add one more line ");
    sw.WriteLine("Add one more line ");
    sw.WriteLine("Done! ");
}
// Write file contents on console. 
using (StreamReader sr = File.OpenText(fileName))
{
    string s = "";
    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
}
Console.WriteLine();
using (StreamWriter sw = fi.AppendText())
{
    sw.WriteLine("--------- Append Text Start ----------");
    sw.WriteLine("New author started");
    sw.WriteLine("a book on Files Programming ");
    sw.WriteLine("using C#");
    sw.WriteLine("--------- Append Text End ----------");
}
// Read all text
string readText = File.ReadAllText(fileName);
Console.WriteLine(readText);

Console.WriteLine();

string destinationFile = @"C:\Users\ayenugula\Documents\Maheshtxtcopy.txt";
try
{
    fi.CopyTo(destinationFile, true);
}
catch (IOException iox)
{
    Console.WriteLine(iox.Message);
}
FileInfo f1 = new FileInfo(destinationFile);
f1.Encrypt();







