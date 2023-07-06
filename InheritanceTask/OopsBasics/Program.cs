
using InheritanceTask.Models;

Console.WriteLine("Hello, World!");
///ConstructorExample newObj= new ConstructorExample(12,"sai");
///Console.ReadLine();
///



//FunctionExample f = new FunctionExample();
//int sub = 0;
//Console.WriteLine(f.Subtrac(20, 10, ref sub));



//Parent p1= new Parent();
//Child c1= new Child();

//Console.WriteLine(p1.Method1());
//Console.WriteLine(c1.Method1());
//p1 = new Child();
////now p1 is object of child class
//Console.WriteLine(p1.Method1());




//PolyMorphism pm=new PolyMorphism();
//Console.WriteLine(pm.Add(5, 6));
//Console.WriteLine(pm.Add(5, 6,12));
//Console.WriteLine(pm.Add((float)5.3, (float)6.6));



//CollectionExample example = new CollectionExample();
//example.ExampleOfArray();


//GenericExample genex= new GenericExample();
//genex.ExampleOfArray();



LINQExample l = new LINQExample();
l.ExampleOfLINQ();

//EncapsulationExample obj1=new EncapsulationExample();
//obj1.originalPrice = 100;

//EncapsulationExample.id = 5;
//Console.WriteLine(EncapsulationExample.id);


//Console.WriteLine(StaticExample.id);
//var i = StaticExample.Subtr(8,90);
//Console.WriteLine(i);
//Console.WriteLine(A1.Rno);
////to access name in class A ,we need to create an instance,as it is not an static variable
//A1 a=new A1();
//Console.WriteLine(a.Name);




//class program {
//    static void Main()
//    {

//        Bikes b = new Bikes();

//b[0] = new BikeParts
//{
//    Name = "M1",
//    Part1 = "wwer",
//    Part2 = "Horm",
//    Part3 = "rets"
//};

//b[1] = new BikeParts
//{
//    Name = "M2",
//    Part1 = "wwer",
//    Part2 = "Horm",
//    Part3 = "rets"
//};

//b[2] = new BikeParts
//{
//    Name = "M3",
//    Part1 = "wwer",
//    Part2 = "Horm",
//    Part3 = "rets"
//};


//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine("************************************************");
//            Console.WriteLine(b[i].Name + " " + b[i].Part1);
//            Console.WriteLine("************************************************");
//        }

// Keep the console window open in debug mode.
//    Console.WriteLine("Press any key to exit.");
//    Console.ReadKey();
//}
/* Output:
    Element #0 = 56.2
    Element #1 = 56.7
    Element #2 = 56.5
    Element #3 = 58.3
    Element #4 = 58.8
    Element #5 = 60.1
    Element #6 = 65.9
    Element #7 = 62.1
    Element #8 = 59.2
    Element #9 = 57.5
*/
//}


//var obj1 = new IE();
//obj1[0] = 15.3F;
//obj1[1] = 12.32F;
//for (int i = 0; i < 2; i++)
//{
//    Console.WriteLine(obj1[i]);
//}



//A ob1 = new A();
//ob1[0] = 23;
//ob1[1] = 21; ;
//ob1[2] = 67;
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(ob1[i]);
//}

//Bike b=new Bike();
//b[0] = new BikeParts
//{

//    last2digits = 43,
//    company = "xyz",
//    color = "r"
//};

//b[1] = new BikeParts
//{

//    last2digits = 45,
//    company = "xys",
//    color = "b"
//};

//b[2] = new BikeParts
//{

//    last2digits = 21,
//    company = "abc",
//    color = "w"
//};
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(b[i].company + " " + b[i].color);
//}
//Console.ReadLine();




//var ob = new C2();
//Console.WriteLine(ob.Aj(5, 6));
//Console.ReadLine();


//var ob12 = new AccessingPrivateVariable();
//ob12.Id = 3;
//Console.WriteLine(ob12.Id);
//Console.ReadLine();

//var ob1 = new ReadOnlyVariable();
///*ob1.Id = 56;*///can't do,bcoz id is readonly variable i.e set is removed while declaring
//Console.WriteLine(ob1.Id);
//Console.ReadLine();

//var ob1=new WriteOnlyExample();
//ob1.id2 = 23;
//Console.WriteLine(ob1.id1);//can't retrieve bcoz it lacks the get accessor



//ASYNC PROGRAMMING

//class P
//{
//    static void Main(string[] args)
//    {
//        Method1();
//        Method2();
//        Console.ReadKey();
//    }

//    public static async Task Method1()
//    {
//        await Task.Run(() =>
//        {
//            for (int i = 0; i < 100; i++)
//            {
//                Console.WriteLine(" Method 1 " + i);
//                // Do something
//                Task.Delay(3000);
//            }
//        });
//    }


//    public static async void Method2()
//    {
//        await Task.Run(() =>
//        {
//            for (int i = 0; i < 100; i++)
//            {
//                Console.WriteLine("---------------------------------------- Method 2 -- " + i);
//                // Do something
//                Task.Delay(1000);
//            }
//        });
//    }
//}

//Example o1=new Example();
//o1.b = 34;
//Console.WriteLine(o1.b);
//Console.ReadLine();







