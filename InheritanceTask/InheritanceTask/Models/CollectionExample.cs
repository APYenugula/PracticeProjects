using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InheritanceTask.Models
{

    public class CollectionExample
    {
        public void ExampleOfArray()
        {
            var x = 10;

            int[] nos = new int[10];
            nos[0] = 1; nos[1] = 2; nos[2] = 3;
            foreach (int i in nos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("@@@@@@@@@@");

            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("SSS");
            arrayList.Add(true);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("@@@@@@@@@@");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("@@@@@@@@@@");


            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            q.Enqueue(4);
            q.Dequeue();
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }



            object obj = "Raj"; // Boxing
            string name = obj.ToString();// unboxing
        }
    }
}
