// See https://aka.ms/new-console-template for more information
using ParentLib;

Console.WriteLine("Hello, World!");
CompanyDetails c=new CompanyDetails();
c.GetCompDelegate = new GetCompanyNameDelegate(ClientFunction);
c.myevent += event_method;
string companyname = c.caller();
Console.WriteLine(companyname);


string event_method()
{
    return "from event method";
}

string ClientFunction()
{
    return "Shippy company";
}