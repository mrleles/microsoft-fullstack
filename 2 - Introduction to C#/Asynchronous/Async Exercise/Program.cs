public class Program
{
    public static async Task PerformLongOperationAsync()
    {
        try
        {
            Console.WriteLine("Task is executing");
            await Task.Delay(3000);
            throw new InvalidOperationException("Simulated error.");
            Console.WriteLine("Task executed");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Task will be executed");
        Task.Run(async () => await PerformLongOperationAsync()).Wait();
    }
}
