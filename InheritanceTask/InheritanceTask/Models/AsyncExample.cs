namespace InheritanceTask.Models
{
    public class AsyncExample
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1 " + i);
                    // Do something
                    Task.Delay(3000);
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
                    Task.Delay(1000);
                }
            });
        }
    }
}
