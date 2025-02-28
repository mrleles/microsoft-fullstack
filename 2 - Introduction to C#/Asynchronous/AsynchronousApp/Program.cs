using System.Threading.Tasks;

public class Program
{
    public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(5000);
        Console.WriteLine("Download finished.");
    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download 2 started...");
        await Task.Delay(5000);
        Console.WriteLine("Download 2 finished.");
    }

    public static async Task Main(string[] args)
    {
        try
        {
            Program program = new Program();
            Task task1 = program.DownloadDataAsync();
            Task task2 = program.DownloadDataAsync2();
            await Task.WhenAll(task1, task2);
            throw new InvalidOperationException("Simulated exception");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
