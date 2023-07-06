using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace InheritanceTask.Models
 
{
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
    }
    public class LINQExample
    {
        public void ExampleOfLINQ()
        {
            List<int> l = new List<int>();
            l.Add(5);
            l.Add(600);
            l.Add(87);
            var coll1 = from i in l
                        orderby i descending
                        select i;
            foreach(var i in coll1)
            {
                Console.WriteLine(i);
            }
            List<student> l2 = new List<student>();
            l2.Add(new student{Id=12,Name="an",Rank=41});
            l2.Add(new student { Id = 123, Name = "anish", Rank = 3 });
            l2.Add(new student { Id = 2, Name = "anuhya", Rank = 12 });
            var coll2 = from i in l2
                        orderby i.Rank ascending
                        select i.Name;
            foreach (var i in coll2)
            {
                Console.WriteLine(i);
            }
            var coll3 = from i in l2
                        orderby i.Rank ascending
                        /*select new { Name = i.Name, rank = i.Rank, id = i.Id }*/
                        select new { fullname=i.Name, rankGot=i.Rank };
            //we can even write  select new {i.Name,i.Rank};
            foreach (var i in coll3)
            {
                Console.WriteLine(i);
            }

        }

    }
}
