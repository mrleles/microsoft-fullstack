// using System.Collections.Generic;
// using System.Threading.Tasks;
public class DataService
{
    public async Task<List<string>> FetchProducts()
    {
        await Task.Delay(500);
        return new List<string>
        {
            "Product 1",
            "Product 2",
            "Product 3"
        };
    }
}