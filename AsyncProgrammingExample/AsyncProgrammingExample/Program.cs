// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Method1();
        Method2();
        Console.ReadKey();
    }

    public static async Task Method1()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" Method 1 " + i);
                // Do something
                Task.Delay(3000).Wait();

            }
        });
    }


    public static async void Method2()
    {
         await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("---------------------------------------- Method 2 -- " + i);
                // Do something
                Task.Delay(1000).Wait();
            }
        });
    }
}
