// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Data;
using System.Data.SqlClient;
SqlConnection con = new SqlConnection("Data Source=AYENUGUL-L-5517\\SQLEXPRESS;Initial Catalog=ado.net_practice;User ID=sa;Password=Welcome2evoke@1234");
SqlCommand com_create = new SqlCommand("create table table1(id int,name varchar(30))", con);
con.Open();
SqlCommand c = new SqlCommand("Sp_select", con);
c.CommandType = CommandType.StoredProcedure;
SqlDataReader dr = c.ExecuteReader();
while (dr.Read())
{
    Console.Write(dr[0].ToString()+"  ");
    Console.WriteLine(dr[1].ToString());
}
con.Close();