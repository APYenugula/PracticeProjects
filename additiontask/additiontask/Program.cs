// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//var a=Convert.ToInt32(Console.ReadLine());
//var b= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(a + b);


var a = Console.ReadLine();
var b = Console.ReadLine();
//try
//{
//    if (typeof(a.Convert.ToInt32 == typeof(int))
//    {

//    }
//}
if(int.TryParse(a,out int c) && int.TryParse(b,out int d))
{
    checked
    {
        try
        {
            Console.WriteLine(c + d);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
else
{
    Console.WriteLine("Invalid input");
}