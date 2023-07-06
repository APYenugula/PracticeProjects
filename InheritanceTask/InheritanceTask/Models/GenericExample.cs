using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InheritanceTask.Models
{
    public class GenericExample
    {
        public void ExampleOfArray()
        {
            

            // Generic

            Queue<int> intQ = new Queue<int>();
            intQ.Enqueue(10);
            intQ.Enqueue(20);
            intQ.Enqueue(30);

            List<string> strList = new List<string>();
            strList.Add("A");
            strList.Add("d");
            strList.Add("e");
            strList.Add("b");
            strList.Add("c");

            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************************************************************");
            strList.Sort();

            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }

            List<DateTime> listDates = new List<DateTime>();
            listDates.Add(DateTime.Now.AddDays(1));
            listDates.Add(DateTime.Now.AddDays(-1));
            listDates.Add(DateTime.Now.AddDays(-3));
            listDates.Add(DateTime.Now.AddDays(-2));
            listDates.Add(DateTime.Now.AddDays(3));

            foreach (var item in listDates)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************************************************************");

            listDates.Sort();

            foreach (var item in listDates)
            {
                Console.WriteLine(item);
            }




        }
    }
}